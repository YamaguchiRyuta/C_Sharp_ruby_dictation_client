using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace RubyDictation
{
    public partial class Form1 : Form
    {

        private readonly WebSocketRuby wsr;
        private readonly PostNTE nte;
        private readonly AudioRecorder2 audioRecorder;

        public Form1()
        {
            InitializeComponent();

            wsr = new(this);
            nte = new(this);

            audioRecorder = new(wsr);

            rubyUrl.Text = GetRubyUrl();
            rubyFormat.Text = GetRubyFormatString();

            nteUrl.Text = GetNteUrl();

            bitGroupBox.Enabled = rawFormat.Checked;
            sampleRateGroupBox.Enabled = rawFormat.Checked;
        }

        public static byte[] ReadFile(string filePath)
        {
            using var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            var buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);
            return buffer;
        }

        private string GetRubyUrl()
        {
            return "ws://"
                + rubyIp.Text + ":" + $"{rubyPort.Value}"
                + "/RubyDictationService/streamrecognition"
                + "?" + "x-rd-container-name" + "=" + "Hitachi" + "&&"
                + "x-rd-user-id" + "=" + "HitachiSolutionsTechnology" + "&&"
                + "x-rd-model-name" + "=" + "ja_hst_hitachi";
        }

        private string GetNteUrl()
        {
            return $"http://{nteIp.Text}:{ntePort.Value}/v4/jobs";
        }

        private string GetRubyFormatString()
        {
            string _temp = "format:";

            if (rawFormat.Checked == true)
            {
                _temp += "pcm:";
                if (bit8.Checked == true) _temp += "8:";
                else if (bit16.Checked == true) _temp += "16:";

                if (kHz8.Checked == true) _temp += "8000";
                else if (kHz16.Checked == true) _temp += "16000";
            }

            else if (muLawFormat.Checked == true) _temp += "mulaw:8:8000";
            else if (mp3Format.Checked == true) _temp += "mp3:-1:-1";

            if (ch1.Checked == true) _temp += ":1";
            else if (ch2.Checked == true) _temp += ":2";

            rubyFormat.Text = _temp;
            return _temp;
        }

        private async void RecognizeButton_Click(object sender, EventArgs e)
        {
            inputAudioSettingGroupBox.Enabled = false;
            settingTableLayoutPanel.Enabled = false;
            recognizeButton.Enabled = false;
            resultTableLayoutPanel.Enabled = true;
            RecognizeStopButton.Enabled = deviceAudioInput.Checked;

            rubyPartial1.Text = "話者１: ";
            rubyPartial2.Text = "話者２: ";

            rubyConsole.Text = "";
            NteConsole.Text = "";

            Debug.WriteLine(wsr.State());

            wsr.SetUrl(new Uri(rubyUrl.Text));
            nte.SetUrl(new Uri(nteUrl.Text));

            await wsr.Connect();

            await wsr.SendText("status");
            await wsr.SendText(rubyFormat.Text);

            if (fileAudioInput.Checked==true)
            {
                byte[] data = ReadFile(audioPath.Text);

                await wsr.SendBinary(data);
                await wsr.SendText("complete");

                nte.Send(data);
                NteConsole.Text = "認識完了を待っています...";
            }
            else if (deviceAudioInput.Checked == true)
            {
                audioRecorder.Setup();
            }

        }

        public void setNteConsoleText(string text)
        {
            NteConsole.Text = text;
        }

        private async void RecognizeStopButton_Click(object sender, EventArgs e)
        {
            audioRecorder.Stop();
            await wsr.SendText("complete");
            // await wsr.SendText("stop");
        }


        private void RubyIp_TextChanged(object sender, EventArgs e)
        {
            rubyUrl.Text = GetRubyUrl();
        }

        private void RubyPort_ValueChanged(object sender, EventArgs e)
        {
            rubyUrl.Text = GetRubyUrl();
        }

        private void nteIp_TextChanged(object sender, EventArgs e)
        {
            nteUrl.Text = GetNteUrl();
        }

        private void ntePort_ValueChanged(object sender, EventArgs e)
        {
            nteUrl.Text = GetNteUrl();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new();
            fileDialog.Title = "音声認識対象を選択してください";
            if (fileDialog.ShowDialog() == DialogResult.OK)
                audioPath.Text = fileDialog.FileName;

            // オブジェクトを破棄する
            fileDialog.Dispose();
        }

        private void RawFormat_CheckedChanged(object sender, EventArgs e)
        {
            GetRubyFormatString();

            bitGroupBox.Enabled = rawFormat.Checked;
            sampleRateGroupBox.Enabled = rawFormat.Checked;
        }

        private void MuLawFormat_CheckedChanged(object sender, EventArgs e)
        {
            GetRubyFormatString();
        }

        private void Mp3Format_CheckedChanged(object sender, EventArgs e)
        {
            GetRubyFormatString();
        }

        private void Ch1_CheckedChanged(object sender, EventArgs e)
        {
            GetRubyFormatString();
        }

        private void Ch2_CheckedChanged(object sender, EventArgs e)
        {
            GetRubyFormatString();
        }

        private void Bit8_CheckedChanged(object sender, EventArgs e)
        {
            GetRubyFormatString();
        }

        private void Bit16_CheckedChanged(object sender, EventArgs e)
        {
            GetRubyFormatString();
        }

        private void KHz8_CheckedChanged(object sender, EventArgs e)
        {
            GetRubyFormatString();
        }

        private void KHz16_CheckedChanged(object sender, EventArgs e)
        {
            GetRubyFormatString();
        }

        private void DeviceAudioInput_CheckedChanged(object sender, EventArgs e)
        {
            audioPath.Enabled = !deviceAudioInput.Checked;
            selectButton.Enabled = !deviceAudioInput.Checked;

            formatGroupBox.Enabled = !deviceAudioInput.Checked;
            channelGroupBox.Enabled = !deviceAudioInput.Checked;
            bitGroupBox.Enabled = !deviceAudioInput.Checked;
            sampleRateGroupBox.Enabled = !deviceAudioInput.Checked;

            nteGroupBox.Enabled = !deviceAudioInput.Checked;
            nteResultGroupBox.Enabled = !deviceAudioInput.Checked;

            if (deviceAudioInput.Checked == true)
                rubyFormat.Text = "format:pcm:16:16000:2";
            else rubyFormat.Text = GetRubyFormatString();
        }
    }
}
