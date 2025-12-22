using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriCore_OS.Grafika;
using TriCore_OS.Login;

namespace TriCore_OS
{
    internal class Login_Engine
    {
        FileEngine fileEngine = new FileEngine();
        loginScreenUI loginUI = new loginScreenUI();
        public void StartLoginProcess()
        {
            Console.Clear();
            fileEngine.FileStart(new LoginDetailsExtraction());
        }
        public void LoginProcess()
        {
            loginUI.LoginScreenUIDo();
            Console.CursorVisible = true;
            CenteringCursor();
            fileEngine.FileLoginProcess(new LoginDetailsExtraction());
            
        }

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
