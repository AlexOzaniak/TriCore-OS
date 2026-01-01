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
"█    │ 01  │ Calculator                    │ v1.2.0        │ Running       │ System        │           █",
"█    │ 02  │ Text editor                   │ v1.5.3        │ Idle          │ Tool          │           █",
"█    │ 03  │ Basic text editor             │ v2.0.1        │ Running       │ Tool          │           █",
"█    │ 04  │ MS pain for 3D drawing        │ v1.1.4        │ Active        │ Tool          │           █",
"█    │ 05  │ File explorer                 │ v3.4.2        │ Idle          │ System        │           █",
"█    │ 06  │ Task manager                  │ v1.0.0        │ Running       │ System        │           █",
"█    │ 07  │ Command Prompt                │ v2.2.6        │ Active        │ System        │           █",
"█    │ 08  │ PowerShell termina            │ v1.8.9        │ Idle          │ System        │           █",
"█    │ 09  │ Screen magnifier              │ v1.3.1        │ Idle          │ Tool          │           █",
"█    │ 10  │ ScreenShot tool               │ v1.0.7        │ Scheduled     │ Tool          │           █",
"█    │ 11  │ Spotify music player          │ v1.0.7        │ Scheduled     │ App           │           █",                                                                                                      █",
"█    │ 12  │ Google Chrome browser         │ v1.0.7        │ Scheduled     │ Network       │           █",                                                                                                      █",
"█    │ 13  │ Windows Media Player          │ v1.0.7        │ Scheduled     │ System        │           █",                                                                                                      █",
"█    │ 14  │ Registry Editor               │ v1.0.7        │ Scheduled     │ System        │           █",
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
