using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace RiseOfUltron_29Feb2016
{
    public static class SharedData
    {
        public static char OptionSelect;
        public static int[] phase1Correct = { 0, 0, 0, 0, 0 };
        public static int quesSelect;
        public static BreachTwo brTwo;

        public static void backgroundMusicPlay()
        {
            SoundPlayer backMusic = new SoundPlayer(Resources.Audio.Audio.BackgroundMusic_converted);
            backMusic.PlayLooping();
        }
    }
}
