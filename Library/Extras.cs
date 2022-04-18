using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Library
{
    public class Extras
    {
        /// <summary>
        /// To utilize this sound player, System.Windows.Extensions has to be installed and files must be converted to .wav.
        /// </summary>
        public static void PlayMusic()
        {
            //Incredible background music is The Bard's Tale by RandomMind, available at  https://www.chosic.com/download-audio/27015/
            //This track is free to use for commercial and non-commercial purposes with no attribution required.
            SoundPlayer musicPlayer = new SoundPlayer();
            musicPlayer.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "./The_Bards_Tale.wav";
            musicPlayer.PlayLooping();
        }

    }
}
