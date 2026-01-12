using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.BabetaMaster
{
    public  class MusicPlayer
    {
        SoundPlayer player;
        private readonly string MusicPath =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "MusicBabetaMaster"
            );

        public  void Play(string soundName)
        {
            string fullPath = Path.Combine(MusicPath, soundName);

            if (!File.Exists(fullPath))
            {
                Console.WriteLine("Zvuk neexistuje: " + fullPath);
                return;
            }

            player = new SoundPlayer(fullPath);
            player.Play();
        }
        public void Stop()
        {
            if (player != null)
                player.Stop();
        }
    }
}
