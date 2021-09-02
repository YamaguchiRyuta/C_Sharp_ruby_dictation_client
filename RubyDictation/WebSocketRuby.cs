using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

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
class RubyWords
{
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
        bool[] completeFlag = { false, false };
        const int MessageBufferSize = 1024 * 10;
        readonly Form1 form1;
        private Uri rubyUrl;

        WebSocketReceiveResult received;
        //クライアント側のWebSocketを定義
        private readonly ClientWebSocket _ws = new();

        public WebSocketRuby(Form1 form1)
        {
            this.form1 = form1;
        }

        public void SetUrl(Uri uri)
        {
            rubyUrl = uri;
            // if (_ws.State == WebSocketState.Open) Close(string.Empty);
        }

        public async Task<ClientWebSocket> Connect()
        {
            if (_ws.State == WebSocketState.Closed || _ws.State == WebSocketState.None)
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
                try
                {
                    received = await _ws.ReceiveAsync(buff, CancellationToken.None);
                }
                catch (WebSocketException e)
                {
                    Debug.WriteLine(e);
                }
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
                catch (JsonReaderException /*e*/)
                {
                    // Debug.WriteLine(e);
                    Debug.WriteLine($"Rudy Dictation String: {result}");
                }
                catch (JsonSerializationException e)
                {
                    Debug.WriteLine(e);
                    Debug.WriteLine($"Rudy Dictation String: {result}");
                }

                if (json == null)
                {
                    completeFlag = new bool[] { false, false };
                    Close(string.Empty);
                    form1.inputAudioSettingGroupBox.Enabled = true;
                    form1.settingTableLayoutPanel.Enabled = true;
                    form1.recognizeButton.Enabled = true;
                    form1.RecognizeStopButton.Enabled = false;
                    form1.rubyPartial1.Text = "話者１: ";
                    form1.rubyPartial2.Text = "話者２: ";
                    continue;
                }
                Debug.WriteLine(json.AsrStatus);
                Debug.WriteLine(result);
                // Debug.WriteLine(json);

                string asrStatus = json.AsrStatus;
                int ch = json.Ch;

                if (asrStatus == "partial")
                {
                    string text = json.Contexts[0].Text;

                    if (text == "") text = "(無音)";

                    if (ch == 0)
                        form1.rubyPartial1.Text = $"話者１: {text}";
                    else
                        form1.rubyPartial2.Text = $"話者２: {text}";
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
                    /*
                    if (json.Contexts[0].Text != "") form1.rubyConsole.AppendText($"complete: 話者: {ch + 1} --------------------\r\n");

                    foreach (RubyContext context in json.Contexts)
                    {
                        float start = context.SoundStartSec;
                        string text = context.Text;

                        if (text != "") form1.rubyConsole.AppendText($"start: {start}, 話者: {ch + 1}, {text}\r\n");
                    }
                    if (json.Contexts[0].Text != "") form1.rubyConsole.AppendText("----------------------------------------\r\n");
                    */

                    completeFlag[ch] = true;

                    if (ch == 0) form1.rubyPartial1.Text = "話者１: (完了)";
                    else form1.rubyPartial2.Text = "話者２: (完了)";

                    if (completeFlag[0] == true && (completeFlag[1] == true || form1.ch1.Checked == true))
                    {
                        Debug.WriteLine("終わった");

                        completeFlag = new bool[] { false, false };
                        // Close(string.Empty);
                        form1.inputAudioSettingGroupBox.Enabled = true;
                        form1.settingTableLayoutPanel.Enabled = true;
                        form1.recognizeButton.Enabled = true;
                        form1.RecognizeStopButton.Enabled = false;
                        if (form1.rubyConsole.Text == "") form1.rubyConsole.Text = "テキストなし";
                    }
                }
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

            if (data == "stop")
            {
                // stopped = true;
                // Close(string.Empty);
            }

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
                try
                {
                    await _ws.CloseAsync(
                    WebSocketCloseStatus.NormalClosure,
                    data,
                    CancellationToken.None
                    );
                }
                catch (WebSocketException e)
                {
                    Debug.WriteLine(e);
                }
            }
        }

        public WebSocketState State()
        {
            return _ws.State;
        }
    }
}