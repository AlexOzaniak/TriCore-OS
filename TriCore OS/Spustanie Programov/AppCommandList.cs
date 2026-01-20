using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.Spustanie_Programov
{
    internal class AppCommandList
    {
        public void ShowCommands()
        {
            // lowkey nepotrebne LOL!!
            AppsMenuContr appsMenuContr = new AppsMenuContr();
           // appsMenuContr.AppsMenuControl();
            StartingProgram startingProgram1 = new StartingProgram();
            Console.ReadKey();
            
            //treba tu este pridat aby sa to vratilo do menu po napisani end
            Console.WriteLine("Showing List Of All  Commands");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int j = 0; j < 2; j++)
            {
                
                for (int i = 0; i < 7; i++)
                {
                    Console.Write("</*/>");
                    Thread.Sleep(220);

                }
                Console.WriteLine();
            }
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("calc - Calculator");
            DelayForCommands();
            Console.WriteLine("notepad - Text editor");
            DelayForCommands();
            Console.WriteLine("wordpad - Basic text editor");
            DelayForCommands();
            Console.WriteLine("mspaint - MS Paint for drawing");
            DelayForCommands();
            Console.WriteLine("mspaint3d - Paint 3D for 3D drawing");
            DelayForCommands();
            Console.WriteLine("explorer - File Explorer");
            DelayForCommands();
            Console.WriteLine("taskmgr - Task Manager");
            DelayForCommands();
            Console.WriteLine("cmd - Command Prompt");
            DelayForCommands();
            Console.WriteLine("powershell - PowerShell terminal");
            DelayForCommands();
            Console.WriteLine("magnify - Screen magnifier");
            DelayForCommands();
            Console.WriteLine("snippingtool - Screenshot tool");
            DelayForCommands();
            Console.WriteLine("spotify - Spotify music player");
            DelayForCommands();
            Console.WriteLine("chrome - Google Chrome browser");
            DelayForCommands();
            Console.WriteLine("wmplayer - Windows Media Player");
            DelayForCommands();
            Console.WriteLine("regedit - Registry Editor");
            DelayForCommands();
            Console.WriteLine("babbeta - Babbeta Master Skalite Edition");
            DelayForCommands();
            Console.WriteLine("END - Go back to home screen");
            DelayForCommands();
    
            Console.WriteLine("kolkus - hmm what could that be ??");

           
            //startingProgram1.StartProgram();

            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int j = 0; j < 2; j++)
            {

                for (int i = 0; i < 7; i++)
                {
                    Console.Write("</*/>");
                    Thread.Sleep(45);

                }
                Console.WriteLine();
            }
            Console.ResetColor();





        }
        public void DelayForCommands()
        {
            Thread.Sleep(25);
        }
    }
}
