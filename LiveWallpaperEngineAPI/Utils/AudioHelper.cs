﻿using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.Text;

namespace Giantapp.LiveWallpaper.Engine.Utils
{
    public static class AudioHelper
    {
        static AudioHelper()
        {
            var deviceEnumerator = new MMDeviceEnumerator();
            var device = deviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
        }
        public static int GetVolume(int pId)
        {
            throw new NotImplementedException();
        }

        public static void SetVolume(int pId, int v)
        {
            throw new NotImplementedException();
        }
    }
}
