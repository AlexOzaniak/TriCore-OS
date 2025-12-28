using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.Grafika
{
    internal class AppsList
    {
        private void BuildAppsList()
        {
            string[] AppsList = new string[]
            {
"████████████████████████████████████████████████████████████████████████████████████████████████████████",
"█                                                                                                      █",
"█      ████████╗██████╗ ██╗      ██████╗ ██████╗ ██████╗ ███████╗                                      █",
"█      ╚══██╔══╝██╔══██╗██║     ██╔════╝██╔═══██╗██╔══██╗██╔════╝                                      █",
"█         ██║   ██████╔╝██║     ██║     ██║   ██║██████╔╝█████╗                                        █",
"█         ██║   ██╔══██╗██║     ██║     ██║   ██║██╔══██╗██╔══╝                                        █",
"█         ██║   ██║  ██║███████╗╚██████╗╚██████╔╝██║  ██║███████╗                                      █",
"█         ╚═╝   ╚═╝  ╚═╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝  ╚═╝╚══════╝                                      █",
"█                                                                                                      █",
"█                               A P P L I C A T I O N S   L I S T                                      █",
"█                                                                                                      █",
"████████████████████████████████████████████████████████████████████████████████████████████████████████",
"█                                                                                                      █",
"█    ┌─────┬───────────────────────────────┬───────────────┬───────────────┬───────────────┐           █",
"█    │  #  │ Application Name              │ Version       │ Status        │ Category      │           █",
"█    ├─────┼───────────────────────────────┼───────────────┼───────────────┼───────────────┤           █",
"█    │ 01  │ TriCore File Manager          │ v1.2.0        │ Running       │ System        │           █",
"█    │ 02  │ TriCore Terminal              │ v1.5.3        │ Idle          │ System        │           █",
"█    │ 03  │ Settings Center               │ v2.0.1        │ Running       │ System        │           █",
"█    │ 04  │ Network Control               │ v1.1.4        │ Active        │ Network       │           █",
"█    │ 05  │ Media Player                  │ v3.4.2        │ Idle          │ Multimedia    │           █",
"█    │ 06  │ App Store                     │ v1.0.0        │ Running       │ Services      │           █",
"█    │ 07  │ Task Monitor                  │ v2.2.6        │ Active        │ System        │           █",
"█    │ 08  │ Text Editor                   │ v1.8.9        │ Idle          │ Utilities     │           █",
"█    │ 09  │ Calculator                    │ v1.3.1        │ Idle          │ Utilities     │           █",
"█    │ 10  │ Update Manager                │ v1.0.7        │ Scheduled     │ System        │           █",
"█    └─────┴───────────────────────────────┴───────────────┴───────────────┴───────────────┘           █",
"█                                                                                                      █",
"█   [ ENTER ] Launch App      [ DEL ] Uninstall      [ F5 ] Refresh      [ ESC ] Back to Home          █",
"█                                                                                                      █",
"████████████████████████████████████████████████████████████████████████████████████████████████████████"
};


            int StartY = (Console.WindowHeight / 2) - (AppsList.Length / 2);
            int widthConsole = Console.WindowWidth;

            for (int i = 0; i < AppsList.Length; i++)
            {
                string line = AppsList[i];
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
        public void AppsListDo()
        {
            Console.Clear();
            BuildAppsList();
        }

    }
}
