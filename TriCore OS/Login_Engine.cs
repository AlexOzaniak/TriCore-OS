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
            fileEngine.FileLoginProcess(new LoginDetailsExtraction());
            
        }
    }
}
