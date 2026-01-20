using System;

namespace TriCore_OS.BabetaMaster
{
    public class Menu
    {
        private MusicPlayer music;
      
       

        public bool menu( )
        {
            Play babettaPlay = new Play();
            while (true)
            {
                music = new MusicPlayer();
                music.Play("MenuSong.wav");
                Console.Clear();
                System.Threading.Thread.Sleep(500);
                Console.SetCursorPosition(70, 18);
                Console.WriteLine("1. HRAŤ");
                Console.SetCursorPosition(70, 21);
                Console.WriteLine("2. NASTAVENIA");
                Console.SetCursorPosition(70, 24);
                Console.WriteLine("3. O HRE");
                Console.SetCursorPosition(70, 27);
                Console.WriteLine("4. KONIEC");
                char input = char.ToLower(Console.ReadKey(true).KeyChar);
                switch (input)
                {
                    case '1':
                        loading();
                        music.Stop();
                        babettaPlay.PlayGame();
                        break;
                    case '2':
                        Settings();
                        break;
                    case '3':
                        AbouttheGame();
                        break;
                    case '4':
                        music.Stop();
                        Console.Clear();
                        return true;
                }
            }
        }

        public void Settings()
        {
            while (true)
            {
                Console.Clear();
                Thread.Sleep(500);
                Console.SetCursorPosition(65, 18);
                Console.WriteLine("Základné ovládanie hry:");
                Thread.Sleep(500);
                Console.SetCursorPosition(65, 20);
                Console.WriteLine("Pokračovať: ENTER");
                Thread.Sleep(500);
                Console.SetCursorPosition(65, 21);
                Console.WriteLine("Voziť sa na babete: W");
                Thread.Sleep(500);
                Console.SetCursorPosition(65, 22);
                Console.WriteLine("Opravovať babetu, vyberať veci z babety: O");
                Thread.Sleep(500);
                Console.SetCursorPosition(65, 23);
                Console.WriteLine("Brať veci: R");
                Thread.Sleep(500);
                Console.SetCursorPosition(65, 24);
                Console.WriteLine("Otvárať inventár: E");
                Thread.Sleep(500);
                Console.SetCursorPosition(65, 25);
                Console.WriteLine("Zobrať vec do ruky: Q");
                Thread.Sleep(500);
                Console.SetCursorPosition(65, 26);
                Console.WriteLine("Spať: F");
                Thread.Sleep(500);
                Console.SetCursorPosition(65, 27);
                Console.WriteLine("Štartovať babetu: D");
                Thread.Sleep(500);
                Console.SetCursorPosition(65, 29);
                Console.WriteLine("Vrátiť do menu z Nastavení: ESC");
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Escape)
                {
                    return;
                }
            }
        }

        public void AbouttheGame()
        {
            Console.Clear();
            Thread.Sleep(1000);

            Console.SetCursorPosition(55, 2);
            Console.WriteLine("Ahoj, vítaj v hre BabetaMaster");
            Thread.Sleep(500);
            Console.SetCursorPosition(55, 4);
            Console.WriteLine("Táto hra je simuláciou života v obci s názvom Skalité.");
            Console.SetCursorPosition(55, 5);
            Thread.Sleep(500);
            Console.WriteLine("Budeš hrať za postavu menom David, ktorý sa snaží opraviť svoju babetu.");
            Console.SetCursorPosition(55, 6);
            Thread.Sleep(500);
            Console.WriteLine("Čaká na teba zoznam oprav, ktoré budeš musieť urobiť.");
            Thread.Sleep(500);
            Console.SetCursorPosition(55, 7);
            Console.WriteLine("Odporúčam ti pozrieť si Nastavenia");
            Thread.Sleep(500);
            Console.SetCursorPosition(55, 9);
            Console.WriteLine("Ak sa chceš vrátiť do menu stlač ESC.");
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Escape)
            {
                return;
            }
        }

        public void loading()
        {

            Console.Clear();
            Thread.Sleep(1000);
            Thread.Sleep(200);
            Console.SetCursorPosition(70, 20);
            Console.Write("Loading");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(300);
                Console.SetCursorPosition(79 + i, 20);
                Console.Write(".");
            }
        }
    }
}
