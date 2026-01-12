    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.Grafika
{
    internal class LoadingGraphics
    {


        public void LoadingScreenUI()
        {
            Console.CursorVisible = false;
            Console.Clear();
            LoadingBall();
        }
        private void LoadingUI()
        {
            string[] LoadUI = new string[]
            {
"████████████████████████████████████████████████████████████████████████",
"                                                                        ",
"       ████████ ██████╗ ██╗ ██████╗ ██████╗ ██████╗ ███████╗            ",
"       ╚══██╔══╝██╔══██╗██║██╔════╝██╔═══██╗██╔══██╗██╔════╝            ",
"          ██║   ██████╔╝██║██║     ██║   ██║██████╔╝█████╗              ",
"          ██║   ██╔══██╗██║██║     ██║   ██║██╔══██╗██╔══╝              ",
"          ██║   ██║  ██║██║╚██████╗╚██████╔╝██║  ██║███████╗            ",
"          ╚═╝   ╚═╝  ╚═╝╚═╝ ╚═════╝ ╚═════╝ ╚═╝  ╚═╝╚══════╝            ",
"                                                                        ",
"                              Welcome...                                ",
"                                                                        ",
"████████████████████████████████████████████████████████████████████████"
};

            int startY = (Console.WindowHeight / 2) - (LoadUI.Length / 2) - 2;
            int widthConsole = Console.WindowWidth;
            for (int i = 0; i < LoadUI.Length; i++)
            {
                string line = LoadUI[i];
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

        private void CenteringCursor()
        {
            int centerX = Console.WindowWidth / 2;
            int centerY = Console.WindowHeight / 2;
            int y = centerY + 5;
            int x = Math.Max(0, centerX - 11);
            Console.SetCursorPosition(x, y);
        }

        private void LoadingBall()
        {
            for (int i = 0; i < 2; i++)
            {
                LoadingUI();
                CenteringCursor();
                Console.Write("[░░░░░░░░░░░░░░░░░░░░]");
                Thread.Sleep(300);
                Console.Clear();
                LoadingUI();
                CenteringCursor();
                Console.Write("[██████████░░░░░░░░]");
                Thread.Sleep(300);
                Console.Clear();
                LoadingUI();
                CenteringCursor();
                Console.Write("[██████████████████]");
                Thread.Sleep(300);

            }
        }
    }
}
