using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TriCore_OS.Grafika
{
    internal class loginScreenUI
    {
        private void BuildLoginScreen()
        {
            string[] loginDo =  new string[]
            {
                "██████████████████████████████████████████████████████████████████████████████████████████████████████",
                "█                                                                                                    █",
                "█                       ████████╗██████╗ ██╗   ██████╗ ██████╗ ██████╗ ███████╗                      █",
                "█                       ╚══██╔══╝██╔══██╗██║  ██╔════╝██╔═══██╗██╔══██╗██╔════╝                      █",
                "█                          ██║   ██████╔╝██║  ██║     ██║   ██║██████╔╝█████╗                        █",
                "█                          ██║   ██╔══██╗██║  ██║     ██║   ██║██╔══██╗██╔══╝                        █",
                "█                          ██║   ██║  ██║██║  ╚██████╗╚██████╔╝██║  ██║███████╗                      █",
                "█                          ╚═╝   ╚═╝  ╚═╝╚═╝   ╚═════╝ ╚═════╝ ╚═╝  ╚═╝╚══════╝                      █",
                "█                                                                                                    █",
                "█                       T  R  I  C  O  R  E     O P E R A T I N G     S Y S T E M                    █",
                "█                                                                                                    █",
                "██████████████████████████████████████████████████████████████████████████████████████████████████████",
                "█                                                                                                    █",
                "█     ┌────────────────────────────────────────────────────────────────────────────────────────────┐ █",
                "█     │                                                                                            │ █",
                "█     │                                   U S E R   L O G I N                                      │ █",
                "█     │                                                                                            │ █",
                "█     └────────────────────────────────────────────────────────────────────────────────────────────┘ █",
                "█                                                                                                    █",
                "█                                                                                                    █",
                "█              Username:        _________________________________________________________________    █",
                "█                                                                                                    █",
                "█              Password:        _________________________________________________________________    █",
                "█                                                                                                    █",
                "█                                                                                                    █",
                "█                                                                                                    █",
                "█        ┌─────────────────────────────┐       ┌─────────────────────────────┐                       █",
                "█        │            LOGIN            │       │           SHUTDOWN          │                       █",
                "█        └─────────────────────────────┘       └─────────────────────────────┘                       █",
                "█                                                                                                    █",
                "██████████████████████████████████████████████████████████████████████████████████████████████████████",
            };

            int startY = (Console.WindowHeight / 2) - (loginDo.Length / 2) - 2;
            int widthConsole = Console.WindowWidth;

            for (int i = 0; i < loginDo.Length; i++)
            {
                string line = loginDo[i];
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

        public void LoginScreenUIDo()
        {
            Console.Clear();
            BuildLoginScreen();

        }

      
    }
}
