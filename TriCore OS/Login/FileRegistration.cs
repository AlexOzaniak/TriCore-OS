using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.Login
{

    internal class FileRegistration : FileLogin
    {
        FileEngine engine = new FileEngine();

        public void RegisterDetails()
        {
            Console.WriteLine("Registration");
            Console.WriteLine("Enter your  username:");
            Username = new string[] { Console.ReadLine() };
            Console.WriteLine("Enter your  password:");
            Path = this.Path;
            Password = new string[] { Console.ReadLine() };
            SaveDetails();
            Console.WriteLine("Registration Successful!");
        }
    }




}




