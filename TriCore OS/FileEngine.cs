using System;
using TriCore_OS.Login;
using TriCore_OS.Login.TriCore_OS.Login;

namespace TriCore_OS
{
    public class FileEngine : FileLogin
    {
        public void EngineStart()

        {
            FileRegistration registration = new FileRegistration();
            LoginDetailsExtraction extractor = new LoginDetailsExtraction();

            Console.WriteLine("Before we start, enter path to your .txt file:");
            Path = Console.ReadLine();
            


            Console.Clear();

            Console.WriteLine("Enter your username:");
            Username = new string[] { Console.ReadLine() };

            

            string [] lines = extractor.ExtractName();
            string [] pass = extractor.ExtractPassword();


            if (lines.Length == 0)
            { registration.RegisterDetails(); }
            else if (extractor.ExtractName().Contains(Username[0]))
            { Console.WriteLine("Name Found Sucesfully Enter Password"); ; }

            Console.WriteLine("Enter your password:");
            Password = new string[] { Console.ReadLine() };

            if (extractor.ExtractPassword().Contains(Password[0]))
            {
                Console.WriteLine("Sucesfully Loged In!");
            }


        }
    }
}
