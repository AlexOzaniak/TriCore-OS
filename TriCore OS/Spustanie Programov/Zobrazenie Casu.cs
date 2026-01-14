using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.Spustanie_Programov
{
    internal class Zobrazenie_Casu
    {
        public void ShowTime()
        {
            while (!Console.KeyAvailable || Console.ReadKey(true).Key != ConsoleKey.E)
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
            }
        }
    }
}

