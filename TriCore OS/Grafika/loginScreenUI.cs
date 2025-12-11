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
        private void LoginScreenUI()
        {
            string UI = @"
██████████████████████████████████████████████████████████████████████████████████████████████████████//
█                                                                                                    █//
█                       ████████╗██████╗ ██╗   ██████╗ ██████╗ ██████╗ ███████╗                      █//
█                       ╚══██╔══╝██╔══██╗██║  ██╔════╝██╔═══██╗██╔══██╗██╔════╝                      █//
█                          ██║   ██████╔╝██║  ██║     ██║   ██║██████╔╝█████╗                        █//
█                          ██║   ██╔══██╗██║  ██║     ██║   ██║██╔══██╗██╔══╝                        █//
█                          ██║   ██║  ██║██║  ╚██████╗╚██████╔╝██║  ██║███████╗                      █//
█                          ╚═╝   ╚═╝  ╚═╝╚═╝   ╚═════╝ ╚═════╝ ╚═╝  ╚═╝╚══════╝                      █//
█                                                                                                    █//
█                       T  R  I  C  O  R  E     O P E R A T I N G     S Y S T E M                    █//
█                                                                                                    █//
██████████████████████████████████████████████████████████████████████████████████████████████████████//
                                                                                                      //
█     ┌────────────────────────────────────────────────────────────────────────────────────────────┐ █//
█     │                                                                                            │ █//
█     │                                   U S E R   L O G I N                                      │ █//
█     │                                                                                            │ █//
█     └────────────────────────────────────────────────────────────────────────────────────────────┘ █//
█                                                                                                    █//
█                                                                                                    █//
█              Username:        _________________________________________________________________    █//
█                                                                                                    █//
█              Password:        _________________________________________________________________    █//
█                                                                                                    █//
█                                                                                                    █//
█                                                                                                    █//
█        ┌─────────────────────────────┐       ┌─────────────────────────────┐                       █//
█        │            LOGIN            │       │           SHUTDOWN          │                       █//
█        └─────────────────────────────┘       └─────────────────────────────┘                       █
█                                                                                                    █
██████████████████████████████████████████████████████████████████████████████████████████████████████
";
        }

        public void LoginScreenUIDo()
        {
            Console.Clear();
            LoginScreenUI();
        }

        private void LoginUi()
        {
            Console.WriteLine("██████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.SetCursorPosition(0,0);         //este zmenit podla velkosti
            Console.WriteLine("█                                                                                                    █");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("█                       ████████╗██████╗ ██╗   ██████╗ ██████╗ ██████╗ ███████╗                      █");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("█                       ╚══██╔══╝██╔══██╗██║  ██╔════╝██╔═══██╗██╔══██╗██╔════╝                      █");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("█                          ██║   ██████╔╝██║  ██║     ██║   ██║██████╔╝█████╗                        █");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("█                          ██║   ██╔══██╗██║  ██║     ██║   ██║██╔══██╗██╔══╝                        █");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("█                          ██║   ██║  ██║██║  ╚██████╗╚██████╔╝██║  ██║███████╗                      █");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("█                          ╚═╝   ╚═╝  ╚═╝╚═╝   ╚═════╝ ╚═════╝ ╚═╝  ╚═╝╚══════╝                      █");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("█                                                                                                    █");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("█                       T  R  I  C  O  R  E     O P E R A T I N G     S Y S T E M                    █");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("█                                                                                                    █");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("██████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("█                                                                                                    █");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("█     ┌────────────────────────────────────────────────────────────────────────────────────────────┐ █");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("█     │                                                                                            │ █");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("█     │                                   U S E R   L O G I N                                      │ █");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("█     │                                                                                            │ █");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("█     └────────────────────────────────────────────────────────────────────────────────────────────┘ █");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("█                                                                                                    █");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("█                                                                                                    █");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("█              Username:        _________________________________________________________________    █");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("█                                                                                                    █");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("█              Password:        _________________________________________________________________    █");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("█                                                                                                    █");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("█                                                                                                    █");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("█                                                                                                    █");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("█        ┌─────────────────────────────┐       ┌─────────────────────────────┐                       █");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("█        │            LOGIN            │       │           SHUTDOWN          │                       █");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("█        └─────────────────────────────┘       └─────────────────────────────┘                       █");

        }
    }
}
