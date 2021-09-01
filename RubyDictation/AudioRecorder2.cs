using NAudio.CoreAudioApi;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyDictation
{
    class AudioRecorder2
    {
        WaveInEvent waveIn;
        private readonly WebSocketRuby wsr;

        public AudioRecorder2(WebSocketRuby wsr)
        {
            this.wsr = wsr;
            MMDeviceCollection collection = new MMDeviceEnumerator().EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);
            for (int i = 0; i < collection.Count; i++) Debug.WriteLine(collection[i]);
        }

        public void Setup()
        {

            waveIn = new WaveInEvent();
            // waveIn.WaveFormat = new WaveFormat(44100, WaveIn.GetCapabilities(0).Channels);
            // waveIn.WaveFormat = new WaveFormat(8*1000, WaveIn.GetCapabilities(0).Channels);
            waveIn.WaveFormat = new WaveFormat(16 *1000, WaveIn.GetCapabilities(0).Channels);
            waveIn.StartRecording();

            // var bufferedWaveProvider = new BufferedWaveProvider(waveIn.WaveFormat);
            // bufferedWaveProvider.DiscardOnBufferOverflow = true;
            // using (var resampler = new MediaFoundationResampler(bufferedWaveProvider, new WaveFormat(16000, 2)))

            waveIn.DataAvailable += async (s, a) =>
            {

                // WaveFormat format = new WaveFormat(16000, 16, 2);
                // byte[] buffer = bufferedWaveProvider.Read();
                // using (WaveFormatConversionStream stream = new WaveFormatConversionStream(new WaveFormat(16000, 16, 2), bufferedWaveProvider))
                // using (WaveFormatConversionStream stream = new WaveFormatConversionStream(format, a.Buffer))


                // Debug.WriteLine($"{a.Buffer.Length}");
                await wsr.SendBinary(a.Buffer);
            };
        }

        public void Stop()
        {
            if(waveIn !=null) waveIn.StopRecording();
        }
    }
}
