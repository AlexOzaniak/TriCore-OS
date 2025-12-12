using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.Grafika
{
    internal class TextCentering
    {
        public  void CenterText(string text, int yPosition)
        {
            if (text.Length < Console.WindowWidth && yPosition >= 0 && yPosition < Console.WindowHeight)
            {
                int widthConsole = Console.WindowWidth;
                int xStart = (widthConsole / 2) - (text.Length / 2);

                if (xStart < 0)
                {
                    xStart = 0;
                }

                try
                {
                    Console.SetCursorPosition(xStart, yPosition);
                    Console.Write(text);
                }
                catch (ArgumentOutOfRangeException)
                {
                    
                }
            }
        }

        public void CenterText(string[] lines, int centerY)
        {
            if (lines == null || lines.Length == 0)
                return;

            int height = Console.WindowHeight;
            int widthConsole = Console.WindowWidth;
            int startY = centerY - (lines.Length / 2);

            for (int i = 0; i < lines.Length; i++)
            {
                int y = startY + i;
                if (y < 0 || y >= height)
                    continue;

                string text = lines[i] ?? string.Empty;
                int xStart = (widthConsole / 2) - (text.Length / 2);
                if (xStart < 0)
                    xStart = 0;

                try
                {
                    Console.SetCursorPosition(xStart, y);
                    Console.Write(text);
                }
                catch (ArgumentOutOfRangeException)
                {
                    // ignore lines that don't fit
                }
            }
        }
    }
}


