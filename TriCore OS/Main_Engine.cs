using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriCore_OS.Grafika;
using TriCore_OS.Login;

namespace TriCore_OS
{
    internal class Main_Engine
    {
        // patova classa nepouzivat !!!!!!

            logoScreen logoScreen = new logoScreen();
            FileEngine fileEngine = new FileEngine();
            AppsList appsList = new AppsList();
            FileLogin login = new FileLogin();
            loginScreenUI loginScreenUI = new loginScreenUI();
            MainGraphics mainGraphics = new MainGraphics();
            LoginDetailsExtraction extraction = new LoginDetailsExtraction();
            Login_Engine loginEngine = new Login_Engine();
        public void Engine()
        {
            Console.WriteLine("Tri core");
            Console.ReadLine();
            loginEngine.StartLoginProcess(fileEngine,login);

           

            logoScreen.StartUI();
           Thread.Sleep(2000);
           loginEngine.LoginProcess();
            Console.Clear();
            mainGraphics.mainGraphics();
            Console.ReadLine();
            appsList.AppsListDo();
            Console.ReadLine();
            

        }
    }
}
