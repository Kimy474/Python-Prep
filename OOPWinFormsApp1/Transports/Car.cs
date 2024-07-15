using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace OOPWinFormsApp1.Transports
{
    internal class Car
    {

        public void Sound()
        {
            SoundPlayer player = new SoundPlayer(@"c:\claxon.mp3");
            player.Play();
        }

    }
}
