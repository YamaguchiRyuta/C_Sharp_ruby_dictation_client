using System;
using System.Diagnostics;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

[JsonObject("RubyResponse")]
class RubyResponse
{
    [JsonProperty("asr_id")]
    public int AsrId { get; set; }

    [JsonProperty("asr_segment_id")]
    public int AsrSegmentId { get; set; }

    [JsonProperty("asr_status")]
    public string AsrStatus { get; set; }

    [JsonProperty("ch")]
    public int Ch { get; set; }

    [JsonProperty("contexts")]
    public RubyContext[] Contexts { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }
}

[JsonObject("RubyContext")]
class RubyContext
{
    [JsonProperty("confidence")]
    public float Confidence { get; set; }

    [JsonProperty("context")]
    public string Context { get; set; }

    [JsonProperty("engine_type")]
    public string EngineType { get; set; }

    [JsonProperty("lang")]
    public string Lang { get; set; }

    [JsonProperty("log_power")]
    public float LogPower { get; set; }

    [JsonProperty("model_id")]
    public string ModelId { get; set; }

    [JsonProperty("n-best")]
    public RubyBest[] NBest { get; set; }

    [JsonProperty("sound_end_sec")]
    public float SoundEndSec { get; set; }

    [JsonProperty("sound_start_sec")]
    public float SoundStartSec { get; set; }

    [JsonProperty("text")]
    public string Text { get; set; }

    [JsonProperty("voice_end_sec")]
    public float VoiceEndSec { get; set; }

    [JsonProperty("voice_start_sec")]
    public float VoiceStartSec { get; set; }
}


[JsonObject("RubyBest")]
class RubyBest
{
    [JsonProperty("confidence")]
    public float Confidence { get; set; }

    [JsonProperty("text")]
    public string Text { get; set; }

    [JsonProperty("words")]
    public RubyWords[] Words { get; set; }
}


[JsonObject("RubyWords")]
class RubyWords {
    [JsonProperty("confidence")]
    public float Confidence { get; set; }

    [JsonProperty("end_sec")]
    public float EndSec { get; set; }

    [JsonProperty("pos")]
    public string Pos { get; set; }

    [JsonProperty("pron")]
    public string Pron { get; set; }

    [JsonProperty("start_sec")]
    public float StartSec { get; set; }

    [JsonProperty("text")]
    public string Text { get; set; }
}


namespace RubyDictation
{
    class WebSocketRuby
    {
        const int MessageBufferSize = 1024*10;
        readonly Form1 form1;
        private Uri rubyUrl;
        //クライアント側のWebSocketを定義
        private readonly ClientWebSocket _ws = new();

        public WebSocketRuby(Form1 form1)
        {
            this.form1 = form1;
            Debug.WriteLine(_ws.State);
        }

        public void SetUrl(Uri uri)
        {
            rubyUrl = uri;
            Close(string.Empty);
        }

        public async Task<ClientWebSocket> Connect()
        {
            if (_ws.State != WebSocketState.Open)
            {
                //サーバに対し、接続を開始
                await _ws.ConnectAsync(rubyUrl, CancellationToken.None);
                Listen();
            }
            return _ws;
        }

        private async void Listen()
        {
            while (_ws.State == WebSocketState.Open)
                {
                    var buff = new ArraySegment<byte>(new byte[MessageBufferSize]);
                    var received = await _ws.ReceiveAsync(buff, CancellationToken.None);

                    if (received.MessageType == WebSocketMessageType.Close)
                    {
                        Close("OK");
                    }

                    if (received.MessageType == WebSocketMessageType.Binary)
                    {
                        Close("I don't do binary");
                    }

                    string result = (new UTF8Encoding()).GetString(buff.Take(received.Count).ToArray());

                RubyResponse json = new();
                try
                {
                    json = JsonConvert.DeserializeObject<RubyResponse>(result);
                }
                catch (JsonReaderException e)
                {
                    // Debug.WriteLine(e);
                    Debug.WriteLine($"Rudy Dictation String: {result}");
                }
                catch (JsonSerializationException e)
                {
                    Debug.WriteLine(e);
                    Debug.WriteLine($"Rudy Dictation String: {result}");
                }

                Debug.WriteLine(json.AsrStatus);
                Debug.WriteLine(result);
                // Debug.WriteLine(json);

                string asrStatus = json.AsrStatus;
                int ch = json.Ch;

                if (asrStatus == "partial") {
                    string text = json.Contexts[0].Text;

                    if (text == "") text = "(無音)";

                    if (ch == 0)
                        form1.label1.Text = $"話者１: {text}";
                    else
                        form1.label2.Text = $"話者２: {text}";
                }
                else if (asrStatus == "final")
                {
                    foreach (RubyContext context in json.Contexts)
                    {
                        float start = context.SoundStartSec;
                        string text = context.Text;

                        if (text != "") form1.rubyConsole.AppendText($"start: {start}, 話者: {ch + 1}, {text}\r\n");
                    }
                }
                else if (asrStatus == "complete")
                {
                    if (json.Contexts[0].Text != "") form1.rubyConsole.AppendText($"complete: 話者: {ch + 1} --------------------\r\n");

                    foreach (RubyContext context in json.Contexts)
                    {
                        float start = context.SoundStartSec;
                        string text = context.Text;

                        if (text != "") form1.rubyConsole.AppendText($"start: {start}, 話者: {ch + 1}, {text}\r\n");
                    }

                    if (json.Contexts[0].Text != "") form1.rubyConsole.AppendText("----------------------------------------\r\n");
                }


                if (json.AsrStatus == "final" || json.AsrStatus == "complete")
                {
                    // Debug.WriteLine(result);
                }
                // rubyConsole.Text += result + "\r\n";
                }
        }

        public async Task<string> SendText(string data)
        {
            await Connect();
            await _ws.SendAsync(
                Encoding.ASCII.GetBytes(data),
                WebSocketMessageType.Text,
                true,
                CancellationToken.None
                );
            return "";
        }

        public async Task<string> SendBinary(byte[] data)
        {
            await Connect();
            await _ws.SendAsync(
                data,
                WebSocketMessageType.Binary,
                true,
                CancellationToken.None
                );
            return "";
        }

        public async void Close(string data)
        {
            if (_ws.State == WebSocketState.Open)
            {
                await _ws.CloseAsync(
                WebSocketCloseStatus.NormalClosure,
                data,
                CancellationToken.None
                );
            }
        }
    }
}