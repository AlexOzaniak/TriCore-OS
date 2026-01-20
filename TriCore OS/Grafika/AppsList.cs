using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriCore_OS.Spustanie_Programov;

namespace TriCore_OS.Grafika
{
    internal class AppsList
    {
        StartingProgram startingProgram = new StartingProgram();
        public void BuildAppsList()
        {
            Console.Clear();
            Console.ResetColor();

            string[] AppsList = new string[]
 {
"████████████████████████████████████████████████████████████████████████████████████████████████████████████████████",
"█                                                                                                                  █",
"█      ████████╗██████╗ ██╗      ██████╗ ██████╗ ██████╗ ███████╗                                                  █",
"█      ╚══██╔══╝██╔══██╗██║     ██╔════╝██╔═══██╗██╔══██╗██╔════╝                                                  █",
"█         ██║   ██████╔╝██║     ██║     ██║   ██║██████╔╝█████╗                                                    █",
"█         ██║   ██╔══██╗██║     ██║     ██║   ██║██╔══██╗██╔══╝                                                    █",
"█         ██║   ██║  ██║██║     ╚██████╗╚██████╔╝██║  ██║███████╗                                                  █",
"█         ╚═╝   ╚═╝  ╚═╝╚═╝      ╚═════╝ ╚═════╝ ╚═╝  ╚═╝╚══════╝                                                  █",
"█                                                                                                                  █",
"█                                      A P P L I C A T I O N S   L I S T                                           █",
"█                                                                                                                  █",
"████████████████████████████████████████████████████████████████████████████████████████████████████████████████████",
"█                                                                                                                  █",
"█ ┌─────┬───────────────────────────────┬─────────┬───────────┬───────────┬──────────────┐                         █",
"█ │  #  │ Application Name              │ Version │ Status    │ Category  │ Command      │                         █",
"█ ├─────┼───────────────────────────────┼─────────┼───────────┼───────────┼──────────────┤                         █",
"█ │ 01  │ Calculator                    │ v1.2.0  │ Idle      │ System  │ calc         │                           █",
"█ │ 02  │ Text editor (Notepad)         │ v1.5.3  │ Idle      │ Tool    │ notepad      │                           █",
"█ │ 03  │ MS Paint                      │ v1.1.4  │ Idle      │ Tool    │ mspaint      │                           █",
"█ │ 04  │ File Explorer                 │ v3.4.2  │ Running   │ System  │ explorer     │                           █",
"█ │ 05  │ Task Manager                  │ v1.0.0  │ Running   │ System  │ taskmgr      │                           █",
"█ │ 06  │ Command Prompt                │ v2.2.6  │ Idle      │ System  │ cmd          │                           █",
"█ │ 07  │ PowerShell Terminal           │ v1.8.9  │ Idle      │ System  │ powershell   │                           █",
"█ │ 08  │ Screen Magnifier              │ v1.3.1  │ Idle      │ Tool    │ magnify      │                           █",
"█ │ 09  │ Snipping Tool                 │ v1.0.7  │ Idle      │ Tool    │ snippingtool │                           █",
"█ │ 10  │ Spotify Music Player          │ v1.0.7  │ Idle      │ App     │ spotify      │                           █",
"█ │ 11  │ Google Chrome Browser         │ v1.0.7  │ Idle      │ Network │ chrome       │                           █",
"█ │ 12  │ Windows Media Player          │ v1.0.7  │ Idle      │ System  │ wmplayer     │                           █",
"█ │ 13  │ Registry Editor               │ v1.0.7  │ Idle      │ System  │ regedit      │                           █",
"█ │ 14  │ Recipes                       │ v0.1.0  │ Coming    │ App     │ recipes      │                           █",
"█ │ 15  │ Babbeta Master Skalite        │ v0.9.9  │ Custom    │ Custom  │ babbeta      │                           █",
"█ │ 16  │ Kolkus ???                    │ v?.?.?  │ Unknown   │ Mystery │ kolkus       │                           █",
"█ │ 17  │ System Time                   │ v1.0.0  │ Idle      │ System  │ time         │                           █",
"█ └─────┴───────────────────────────────┴─────────┴───────────┴─────────┴──────────────┘                           █",
"█                                                                                                                  █",
"█   [ ENTER ] Launch App   [ DEL ] Uninstall   [ F5 ] Refresh   [ ESC ] Back to Home                               █",
"█                                                                                                                  █",
"████████████████████████████████████████████████████████████████████████████████████████████████████████████████████"
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
            startingProgram.StartProgram();
        }
        

    }
}
