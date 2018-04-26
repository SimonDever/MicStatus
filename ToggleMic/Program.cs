using System;
using System.Runtime.InteropServices;
using NAudio.CoreAudioApi;

namespace ToggleMic
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            MMDevice audio = null;
            try
            {
                audio = new MMDeviceEnumerator().GetDefaultAudioEndpoint(DataFlow.Capture, Role.Communications);
            }
            catch (COMException e)
            {
                return;
            }

            AudioEndpointVolume volume = audio.AudioEndpointVolume;
            volume.Mute = !volume.Mute;
        }
    }
}
