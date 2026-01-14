using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriCore_OS.Grafika;
using TriCore_OS.Login;

namespace TriCore_OS
{
    public class Login_Engine
    {
        // patova classa nepouzivat !!!!!!
       

        
       



        public void StartLoginProcess(FileEngine fileEngine,FileLogin login)
        {

            Console.Clear();
            fileEngine.FileStart(login);
        }
        public void LoginProcess()
        {
            Login_Engine engine1 = new Login_Engine();


            
            loginUI.LoginScreenUIDo();
            Console.CursorVisible = true;
           engine1.CenteringCursor();

            Thread.Sleep(1000);
            loadingGraphics.LoadingScreenUI();
        }
        loginScreenUI loginUI = new loginScreenUI();
        LoadingGraphics loadingGraphics = new LoadingGraphics();

        public void CenteringCursor()
        {
            int centerX = Console.WindowWidth / 2;
            int centerY = Console.WindowHeight / 2;
            int y = centerY + 3;
            int x = Math.Max(0, centerX - 17);
            Console.SetCursorPosition(x, y);
        }
        internal void CenteringCursorPassword()
        {
            int centerX = Console.WindowWidth / 2;
            int centerY = Console.WindowHeight / 2;
            int y = centerY + 5;
            int x = Math.Max(0, centerX - 17);
            Console.SetCursorPosition(x, y);
        }
    }
}
