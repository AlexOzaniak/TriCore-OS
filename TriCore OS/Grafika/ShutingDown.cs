using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.Grafika
{
    internal class ShutingDown
    {
        private void Screen()
        {
            string[] doShut = new string[]
            {
"████████████████████████████████████████████████████████████████████████",
"                                                                        ",
"                        T R I C O R E                                   ",
"                                                                        ",
"                       Shutting down...                                 ",
"                                                                        ",
"                         ◐   ◑   ◒   ○                                  ",
"                                                                        ",
"              Please wait while the system is closing                   ",
"                                                                        ",
"████████████████████████████████████████████████████████████████████████"

            };
            int StartY = (Console.WindowHeight / 2) - (doShut.Length / 2);
            int widthConsole = Console.WindowWidth;

            for (int i = 0; i < doShut.Length; i++)
            {
                string line = doShut[i];
                int xStart = (widthConsole / 2) - (line.Length / 2);
                if (xStart < 0) xStart = 0;
                int y = StartY + i;
                if (y < 0) y = 0;
                try
                {
                    Console.SetCursorPosition(xStart, y);
                    Console.WriteLine(line);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Error!!");
                }
            }
        }
        internal void ShutingDO()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Screen();
            Thread.Sleep(3000);
            Console.Clear();
            Environment.Exit(0);
        }
    }
}
