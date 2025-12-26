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
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   ───────────────────────────────");
                Console.WriteLine($"      Aktuálny čas: {DateTime.Now:dd.MM.yyyy  HH:mm:ss}");
                Console.WriteLine("   ───────────────────────────────");
                Console.ResetColor();
                Console.WriteLine("\n   Stlač ľubovoľnú klávesu...");
                Console.ReadKey(true);
            }
        }
    }
}   
