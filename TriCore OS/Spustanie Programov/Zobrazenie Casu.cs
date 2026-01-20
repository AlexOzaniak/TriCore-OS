using System;
using System.Threading;
using TriCore_OS.Grafika;

namespace TriCore_OS.Spustanie_Programov
{
    internal class Zobrazenie_Casu
    {
        public void ShowTime()
        {
            bool timeStatus = true;

            while (timeStatus)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   ───────────────────────────────");
                Console.WriteLine($"      Aktuálny čas: {DateTime.Now:dd.MM.yyyy  HH:mm:ss}");
                Console.WriteLine("   ───────────────────────────────");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine(" Press 'E' to go back to menu ");

                
                Thread.Sleep(1000);

                // kontrola vstupu
                if (Console.KeyAvailable)
                {
                    ConsoleKey key = Console.ReadKey(true).Key;

                    if (key == ConsoleKey.E)
                    {
                        timeStatus = false; 
                    }
                    if ( !timeStatus )
                    {
                        Console.Clear();
                        Console.ResetColor();
                            AppsList appsList = new AppsList();
                        appsList.BuildAppsList();
                    }
                }
            }
        }
    }
}


