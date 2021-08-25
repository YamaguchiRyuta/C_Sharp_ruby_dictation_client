using System;
using System.IO;
using System.Windows.Forms;


namespace RubyDictation
{
    public partial class Form1 : Form
    {

        private readonly WebSocketRuby wsr;
        private readonly AudioRecorder2 audioRecorder;

        public Form1()
        {
            InitializeComponent();
            rubyIP.Text = "192.168.13.20"; 
            // rubyFormat.Text = "format:mulaw:8:8000:2";
            // rubyFormat.Text = "format:pcm:16:8000:2";
            rubyFormat.Text = "format:pcm:16:16000:2";
            wsr = new(this);
            audioRecorder = new(wsr);
        }

        public static byte[] ReadFile(string filePath)
        {
            using var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            var buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);
            return buffer;
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            wsr.SetUrl(new Uri(rubyUrl.Text));
        }

        private async void RecognizeButton_Click(object sender, EventArgs e)
        {
            label1.Text = "話者１: ";
            label2.Text = "話者２: ";

            rubyConsole.Text = rubyConsole.Text = "";

            await wsr.SendText("status");
            await wsr.SendText(rubyFormat.Text);
            
            // await wsr.SendBinary(ReadFile("D:\\共有フォルダ\\サウンド\\0000_01_01_20000101_000000_0001.wav"));
            audioRecorder.setup();

            await wsr.SendText("complete");
        }

        private void RubyIP_TextChanged(object sender, EventArgs e)
        {
            rubyUrl.Text = "ws://"
                + rubyIP.Text + ":" + "8302"
                + "/RubyDictationService/streamrecognition"
                + "?" + "x-rd-container-name" + "=" + "Hitachi" + "&&"
                + "x-rd-user-id" + "=" + "HitachiSolutionsTechnology" + "&&"
                + "x-rd-model-name" + "=" + "ja_hst_hitachi";
        }
    }
}
