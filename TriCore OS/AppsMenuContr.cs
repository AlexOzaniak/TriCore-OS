using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TriCore_OS.BabetaMaster;
using TriCore_OS.Grafika;
using TriCore_OS.Kalkulacka;
using TriCore_OS.Spustanie_Programov;

namespace TriCore_OS
{
    internal class AppsMenuContr
    {
        MainGraphics mainUI = new MainGraphics();
        Engine_Calculator calculator = new Engine_Calculator();
        StartingProgram appslist = new StartingProgram();
        AppCommandList appcommandlist = new AppCommandList();
        Menu BabettaMenu = new Menu();
        ShutingDown shutUI = new ShutingDown();
        internal void AppsMenuControl()
        {
            Console.Clear();
            while (true)
            {
                SwitchToApp();
            }
        }

        private void SwitchToApp()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
                mainUI.mainGraphics();
            string appName = Console.ReadLine().Trim();
            switch (appName.ToLower())
            {
                case "calc":
                    calculator.StartCalculator();
                    break;
                case "ap":
                    appslist.StartProgram();
                    break;
                case "babetta":
                   BabettaMenu.menu();
                    break;
                case "apcom":
                    Console.Clear();
                    appcommandlist.ShowCommands();
                    break;
                case "setin":
                    Console.WriteLine("tato aplikacia je este vo vyvoji");
                    Thread.Sleep(2000);
                    break;
                    case "term":
                        Console.WriteLine("tato aplikacia je este vo vyvoji");
                        Thread.Sleep(2000);
                    break;
                case "shut":
                    Console.Clear();
                    shutUI.ShutingDO();
                    break;

                default:
                    Console.WriteLine("App not found. Try again.");
                    Thread.Sleep(2000);
                    break;
            }
        }


    }
}
