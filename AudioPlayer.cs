using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.BlackJack
{
    public class AudioPlayer
    {
        private IWavePlayer waveOutDevice;
        private AudioFileReader audioFileReader;

        public void PlaySound(string filePath)
        {
            Thread playThread = new Thread(() =>
            {
                waveOutDevice = new WaveOutEvent();
                audioFileReader = new AudioFileReader(filePath);
                waveOutDevice.Init(audioFileReader);
                waveOutDevice.Play();
                // Блокируем поток, пока воспроизводится звук
                while (waveOutDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(100);
                }
            });

            playThread.Start();
        }

        public void Stop()
        {
            waveOutDevice?.Stop();
            waveOutDevice?.Dispose();
            audioFileReader?.Dispose();
        }
    }
}
