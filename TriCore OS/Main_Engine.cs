using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriCore_OS.Grafika;

namespace TriCore_OS
{
    internal class Main_Engine
    {
        public void Engine()
        {

            Console.WriteLine("TriCore OS");
            Console.ReadLine();
            Console.Clear();



            logoSchreen logo = new logoSchreen();
            logo.StartUI();
            Console.Clear();
            TextCentering textCenter = new TextCentering();
            loginScreenUI loginUI = new loginScreenUI();

            var loginLines = loginUI.BuildLoginScreen();
            textCenter.CenterText(loginLines, Console.WindowHeight / 2);

            Console.ReadKey();
            Console.Clear();

            MainGraphics homeUI = new MainGraphics();
            homeUI.mainGraphics();
            Console.ReadKey();
        }
    }
}
