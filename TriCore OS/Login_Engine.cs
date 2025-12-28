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
       
        
        public void StartLoginProcess(FileEngine fileEngine)
        {

            Console.Clear();
            //fileEngine.FileStart(new LoginDetailsExtraction());
        }
        public void LoginProcess()
        {
            LoginDetailsExtraction extraction1 = new LoginDetailsExtraction();
            Login_Engine engine1 = new Login_Engine();

            FileEngine fileEngine = new FileEngine();
            loginUI.LoginScreenUIDo();
            Console.CursorVisible = true;
            CenteringCursor();
            fileEngine.FileLoginProcess(extraction1,engine1,fileEngine);
            Thread.Sleep(1000);
            loadingGraphics.LoadingScreenUI();
        }
        loginScreenUI loginUI = new loginScreenUI();
        LoadingGraphics loadingGraphics = new LoadingGraphics();

        private void CenteringCursor()
        {
            int centerX = Console.WindowWidth / 2;
            int centerY = Console.WindowHeight / 2;
            int y = centerY + 3;
            int x = Math.Max(0, centerX - 17);
            Console.SetCursorPosition(x, y);
        }
        public void CenteringCursorPassword()
        {
            int centerX = Console.WindowWidth / 2;
            int centerY = Console.WindowHeight / 2;
            int y = centerY + 5;
            int x = Math.Max(0, centerX - 17);
            Console.SetCursorPosition(x, y);
        }
    }
}
