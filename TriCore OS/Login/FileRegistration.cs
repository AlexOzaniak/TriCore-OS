using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.Login
{


    public class FileRegistration : FileLogin
    {



        public string GetRegisterPassword()
        {
            Console.WriteLine("Enter your  password:");

            Password = Console.ReadLine();

            if (Password == null)
            {
                Console.WriteLine("Password Can not Be Empty");
            }


            return Password;


        }








        public void RegisterDetails()
        {
            FileEngine rngine = new FileEngine();


            Console.WriteLine(@"
______ _____ _____ _____ _____ ___________  ___ _____ _____ _____ _   _ 
| ___ \  ___|  __ \_   _/  ___|_   _| ___ \/ _ \_   _|_   _|  _  | \ | |
| |_/ / |__ | |  \/ | | \ `--.  | | | |_/ / /_\ \| |   | | | | | |  \| |
|    /|  __|| | __  | |  `--. \ | | |    /|  _  || |   | | | | | | . ` |
| |\ \| |___| |_\ \_| |_/\__/ / | | | |\ \| | | || |  _| |_\ \_/ / |\  |
\_| \_\____/ \____/\___/\____/  \_/ \_| \_\_| |_/\_/  \___/ \___/\_| \_/
                                                                        
                                                                        ");

            Console.WriteLine("Enter your  username:");

            Username = Console.ReadLine();

            if (Username == null)
            {
                Console.WriteLine("Username Can not Be Empty");
            }
            PaswordEncrypting encrypting = new PaswordEncrypting();









            SaveDetails(encrypting);
            Console.WriteLine("Registration Successful!");





        }
        public string EncryptedPass(PaswordEncrypting encrypting)
        {
            string EncrypptedPassword = encrypting.Encryption();
            return EncrypptedPassword;
        }


    }




}




