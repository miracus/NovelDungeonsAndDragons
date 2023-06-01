using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Novel.Code
{
    public class SoundPlay
    {
        public static void Play(Stream sounFromResources)
        {
            Stream sound = sounFromResources;
            SoundPlayer soundPlayer = new SoundPlayer(sound);
            soundPlayer.Play();
        }
        public static void Stop(Stream sounFromResources)
        {
            Stream sound = sounFromResources;
            SoundPlayer soundPlayer = new SoundPlayer(sound);
            soundPlayer.Stop();
        }
    }
}
