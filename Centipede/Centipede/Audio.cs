/*
 * Chris Lund Schober
 * IES San Vicente
 * Programing 2
 */
using System;
using System.Collections.Generic;
using Tao.Sdl;

namespace Centipede
{
    /**
      * This class will control audio playings in the video game
      */
class Audio
    {
        List<IntPtr> audios;
        int channels;

        public Audio(int freq, int channels, int bytesPerSample)
        {
            this.channels = channels;
            SdlMixer.Mix_OpenAudio(freq, (short)SdlMixer.MIX_DEFAULT_FORMAT, channels,
                                    bytesPerSample);
            audios = new List<IntPtr>();
        }

        public bool AddWAV(string fileName)
        {
            IntPtr file = SdlMixer.Mix_LoadWAV(fileName);
            if (file == IntPtr.Zero)
                return false;
            audios.Add(file);
            return true;
        }

        public void PlayWAV(int pos, int channel, int numberOfLoops)
        {
            if (pos >= 0 && pos < audios.Count && channel >= 1 && channel <= channels)
                SdlMixer.Mix_PlayChannel(channel, audios[pos], numberOfLoops);
        }

        public bool AddMusic(string fileName)
        {
            IntPtr file = SdlMixer.Mix_LoadMUS(fileName);
            if (file == IntPtr.Zero)
                return false;
            audios.Add(file);
            return true;
        }

        public void PlayMusic(int pos, int numberOfLoops)
        {
            if (pos >= 0 && pos < audios.Count)
                SdlMixer.Mix_PlayMusic(audios[pos], numberOfLoops);
        }

        public void StopMusic()
        {
            SdlMixer.Mix_HaltMusic();
        }

        public void StopChannel(int channel)
        {
            SdlMixer.Mix_HaltChannel(channel);
        }

    }
}
