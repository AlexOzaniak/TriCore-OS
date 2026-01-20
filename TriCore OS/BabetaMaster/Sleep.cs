using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.BabetaMaster
{
    public class Sleep
    {
        public void GoSleep()
        {
            Thread.Sleep(3000);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("System: Si unavený. Budeš pokračovať na ďalší deň");
            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("System: Choď ku posteli");

            while (true)
            {
                char gohomesleep = char.ToLower(Console.ReadKey(true).KeyChar);
                if (gohomesleep == 'w')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 4);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 4);
                    Console.WriteLine("System: Si pri posteli. Choď spať");
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 4);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }

            while (true)
            {
                char gosleep = char.ToLower(Console.ReadKey(true).KeyChar);
                if (gosleep == 'f')
                {
                    Console.Clear();
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(70, 20);
                    Console.Write("Spíš");
                    for (int i = 0; i < 10; i++)
                    {
                        Thread.Sleep(300);
                        Console.SetCursorPosition(79 + i, 20);
                        Console.Write(".");
                    }
                    break;
                }
                else
                {

                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 6);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }
        }
    }
}
