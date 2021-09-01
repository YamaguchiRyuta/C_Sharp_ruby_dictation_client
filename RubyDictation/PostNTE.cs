using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace RubyDictation
{
    class PostNTE
    {
        readonly Form1 form1;
        private Uri nteUrl;
        HttpListener httpListener;

        public PostNTE(Form1 form1)
        {
            this.form1 = form1;

            httpListener = new();
            httpListener.Prefixes.Add("http://+:3000/");
            // httpListener.Prefixes.Add("http://*:3000/");
            httpListener.Start();
            Debug.WriteLine("Listening...");
        }

        private string getIp()
        {
            string result = "";
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    result = ip.ToString();
            }
            return result;
        }

        public void SetUrl(Uri uri)
        {
            nteUrl = uri;
        }

        public async void Send(byte[] data)
        {
            var nteRequest = new NteRequest
            {
                JobType = "batch_transcription",
                OperatingMode = "fast",
                CallbackUrl = $"http://{getIp()}:3000",
                Model = new Model
                {
                    Name = "jpn-jpn"
                },
                Channels = new ChannelsReq
                {
                    FirstChannelLabel = new FirstChannelLabelReq
                    {
                        ResultFormat = "lattice+transcript", // "lattice",
                        Format = "audio/wav",
                        Diarize = false,
                    }
                }
            };

            string jsonStr = JsonConvert.SerializeObject(nteRequest, Formatting.None);

            MultipartFormDataContent multiContent = new MultipartFormDataContent();
            multiContent.Add(new StringContent(jsonStr));
            multiContent.Add(new ByteArrayContent(data), "firstChannelLabel", "AudioFilename");

            HttpClient client = new();

            HttpResponseMessage response;
            try
            {
                response = await client.PostAsync(nteUrl, multiContent);
                Debug.WriteLine(response.ToString());
            }
            catch (HttpRequestException e)
            {
                Debug.WriteLine(e.ToString());
            }

            // Listen();
            // ListenHttp();

            Task<string> task = Task.Run(() =>
            {
                return ListenHttp();
            });
        }

        private async void Listen()
        {
            var tcpListener = new TcpListener(IPAddress.Loopback, 3000);
            tcpListener.Start();

            while (true)
            {
                using (var tcpClient = await tcpListener.AcceptTcpClientAsync())
                using (var stream = tcpClient.GetStream())
                using (var reader = new StreamReader(stream))
                using (var writer = new StreamWriter(stream))
                {
                    // 接続元を出力しておく
                    Console.WriteLine(tcpClient.Client.RemoteEndPoint);

                    // ヘッダー部分を全部読む
                    string line;
                    do
                    {
                        line = await reader.ReadToEndAsync();
                        // 読んだ行を出力しておく
                        Console.WriteLine(line);
                    } while (!String.IsNullOrWhiteSpace(line));
                }
            }
        }

        public string ListenHttp()
        {
            try
            {
                // HttpListener httpListener = new();
                // httpListener.Prefixes.Add("http://+:3000/");
                // httpListener.Prefixes.Add("http://*:3000/");
                // httpListener.Start();

                // Debug.WriteLine("Listening...");

                /*
                // Note: The GetContext method blocks while waiting for a request.
                HttpListenerContext context = httpListener.GetContext();
                HttpListenerRequest request = context.Request;
                // Obtain a response object.
                HttpListenerResponse response = context.Response;
                // Construct a response.
                string responseString = "<HTML><BODY> Hello world!</BODY></HTML>";
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
                // Get a response stream and write the response to it.
                response.ContentLength64 = buffer.Length;
                System.IO.Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                // You must close the output stream.
                output.Close();
                */

                while (httpListener.IsListening)
                {
                    Debug.WriteLine("Wait...");
                    IAsyncResult result = httpListener.BeginGetContext(OnRequested, httpListener);
                    result.AsyncWaitHandle.WaitOne();
                    // httpListener.Stop();
                    // return "";
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
            return "";
        }

        delegate void Delegate(string text);

        private void OnRequested(IAsyncResult result)
        {
            HttpListener clsListener = (HttpListener)result.AsyncState;
            if (!clsListener.IsListening)
            {
                return;
            }

            HttpListenerContext context = clsListener.EndGetContext(result);
            HttpListenerRequest req = context.Request;
            HttpListenerResponse res = context.Response;

            if (req.HttpMethod == "POST")
            {
                StreamReader reader = new(req.InputStream);
                string resBody = reader.ReadToEnd();
                // Debug.WriteLine(reqBody);
                // var json = JsonConvert.DeserializeObject<NteResponse>(reqBody);
                JObject json = JObject.Parse(resBody);

                Debug.WriteLine(resBody);

                string resultText = "";

                var transcript = json["channels"]["firstChannelLabel"]["transcript"];
                if (transcript != null)
                {
                    foreach (var x in transcript)
                    {
                        float start = (float)x["start"];
                        int ch = (int)x["speaker"];
                        string text = (string)x["text"];

                        if (text != "")
                            resultText += $"start: {start}, 話者: {ch}, {text}\r\n";
                    }
                }
                if (resultText == "") resultText = "テキストなし";

                if (form1.InvokeRequired)
                    form1.Invoke(new Delegate(form1.setNteConsoleText), resultText);
                else
                    form1.NteConsole.Text = resultText;
            }

            try
            {
                if (null != res) res.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
        }
    }
}
