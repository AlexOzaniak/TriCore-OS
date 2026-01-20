using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriCore_OS.Spustanie_Programov;

namespace TriCore_OS.BabetaMaster
{
    public class Engine
    {
        public Player player;    
        private MusicPlayer music;
        
        public void Welcome()
        {
            Console.CursorVisible = false;
            Console.WriteLine("Stlač ENTER.");
            Console.ReadLine();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
        }
        public void AboutTheGame()
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
        


            
        }
    }

    





























       

        

        

       

     
            

       

        




