using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TriCore_OS.Grafika
{
    internal class CalculatorGraphics
    {


        internal void CalculatorUI()
        {
            Console.CursorVisible = false;
            Console.Clear();
            CalcGrap();
            Centering();
            Console.CursorVisible = true;
        }
        private void CalcGrap()
        {
            string[] grap = new string[]
            {
"      ░██████             ░██                       ░██               ░██                          ",                        
"     ░██   ░██            ░██                       ░██               ░██                          ",                        
"    ░██         ░██████   ░██  ░███████  ░██    ░██ ░██  ░██████   ░████████  ░███████  ░██░████   ", 
"    ░██              ░██  ░██ ░██    ░██ ░██    ░██ ░██       ░██     ░██    ░██    ░██ ░███       ",     
"    ░██         ░███████  ░██ ░██        ░██    ░██ ░██  ░███████     ░██    ░██    ░██ ░██        ",      
"    ░██    ░██ ░██   ░██  ░██ ░██    ░██ ░██   ░███ ░██ ░██   ░██     ░██    ░██    ░██ ░██        ",      
"     ░██████   ░█████░██ ░██  ░███████   ░█████░██ ░██  ░█████░██     ░████  ░███████   ░██        ", 
            };

            int startY = (Console.WindowHeight / 2) - (grap.Length / 2) - 2;
            int widthConsole = Console.WindowWidth;
            for (int i = 0; i < grap.Length; i++)
            {
                string line = grap[i];
                int xStart = (widthConsole / 2) - (line.Length / 2);
                if (xStart < 0) xStart = 0;
                int y = startY + i;
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

        private void Centering()
        {
            int centerX = Console.WindowWidth / 2;
            int centerY = Console.WindowHeight / 2;
            int y = centerY + 5;
            int x = Math.Max(0, centerX - 17);
            Console.SetCursorPosition(x, y);
    }
    }
}
