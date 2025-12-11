using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.Login
{

    internal class FileRegistration : FileLogin
    {
        public void RegisterDetails()
        {
            Console.WriteLine("Registration");
            Console.WriteLine("Enter your  username:");
            Username = Console.ReadLine();
            Console.WriteLine("Enter your  password:");
           
            Password = Console.ReadLine();
            Password = Console.ReadLine();
            SaveDetails();
            Console.WriteLine("Registration Successful!");
        }
    }




}




