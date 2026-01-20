using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriCore_OS.BabetaMaster;
using TriCore_OS.Grafika;
using TriCore_OS.Kalkulacka;

namespace TriCore_OS.Spustanie_Programov
{

    internal class StartingProgram
    {


        Engine babetaengine = new Engine();
        MusicPlayer babetaplayer = new MusicPlayer();
        Player babettaplayer = new Player();
        SecretKolkus kolkus1 = new SecretKolkus();
        AppsList AppsList = new AppsList();
        Engine_Calculator calculator = new Engine_Calculator();

        public void StartProgram()
        {
            AppsList.AppsListDo();
            string input = "";
            while (input != "END")
            {
                Console.ResetColor();
                Console.Write("Which app do u want to open:");

               Console.ForegroundColor = ConsoleColor.Green;
                input = Console.ReadLine().Trim();
                if (input == "calc")
                {
                    //spustenie Misovej/patovej kalkulacky
                    calculator.StartCalculator();
                    return;
                }
                else if (input == "babetta")
                {
                    //spustenie babbetamastera
                    babetaengine.Loading();
                    babetaengine.Welcome();
                    babetaengine.Menu();
                    babetaengine.AboutTheGame();



                }
                else if (input == "kolkus")
                {

                    kolkus1.Main();
                    
                }

                try
                {

                    Process.Start(new ProcessStartInfo
                    {
                        FileName = input,
                        UseShellExecute = true
                    });
                }

                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("App not found or could not be opened. Please try again.");

                }


            }
        }
    }
}


