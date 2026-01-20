using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.Grafika
{
    internal class Registration
    {
        private  void DoRegistration()
        {
            string[] regist = new string[]
            {
"████████████████████████████████████████████████████████████████████████████████",
"█                                                                              █",
"█      ████████╗██████╗ ██╗ ██████╗ ██████╗ ██████╗ ███████╗                   █",
"█      ╚══██╔══╝██╔══██╗██║██╔════╝██╔═══██╗██╔══██╗██╔════╝                   █",
"█         ██║   ██████╔╝██║██║     ██║   ██║██████╔╝█████╗                     █",
"█         ██║   ██╔══██╗██║██║     ██║   ██║██╔══██╗██╔══╝                     █",
"█         ██║   ██║  ██║██║╚██████╗╚██████╔╝██║  ██║███████╗                   █",
"█                                                                              █",
"█                         R E G I S T R A T I O N                              █",
"█                                                                              █",
"█     ┌────────────────────────────────────────────────────────────────────┐   █",
"█     │                                                                    │   █",
"█     │                         CREATE NEW ACCOUNT                         │   █",
"█     │                                                                    │   █",
"█     └────────────────────────────────────────────────────────────────────┘   █",
"█                                                                              █",
"█          Username:    ____________________________________________________   █",
"█                                                                              █",
"█          Password:    ____________________________________________________   █",
"█                                                                              █",
"█                                                                              █",
"█     ┌──────────────────────────┐        ┌──────────────────────────┐         █",
"█     │        REGISTER          │        │          BACK            │         █",
"█     └──────────────────────────┘        └──────────────────────────┘         █",
"█                                                                              █",
"████████████████████████████████████████████████████████████████████████████████"
};

            int startY = (Console.WindowHeight / 2) - (regist.Length / 2) - 2;
            int widthConsole = Console.WindowWidth;
            for (int i = 0; i < regist.Length; i++)
            {
                string line = regist[i];
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

        public void RegistrationUI()
        {
            Console.Clear();
            DoRegistration();
        }
    }
}
