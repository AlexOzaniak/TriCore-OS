using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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
        internal void AppsMenuControl()
        {
            Console.Clear();
            mainUI.mainGraphics();
            SwitchToApp();
        }

        private void SwitchToApp()
        {
            string appName = Console.ReadLine().Trim();
            switch (appName.ToLower())
            {
                case "calc":
                    calculator.StartCalculator();
                    break;
                case "ap":
                    appslist.StartProgram();
                    break;
                case "bm":
                    Console.WriteLine("neocakavana chyba skus to spustit cez apps list");
                    break;
                case "apcom":
                    Console.Clear();
                    appcommandlist.ShowCommands();
                    break;
                case "setin":
                    Console.WriteLine("tato aplikacia je este vo vyvoji");
                    break;
                    case "term":
                        Console.WriteLine("tato aplikacia je este vo vyvoji");
                    break;
                default:
                    Console.WriteLine("App not found.");
                    break;
            }
        }


    }
}
