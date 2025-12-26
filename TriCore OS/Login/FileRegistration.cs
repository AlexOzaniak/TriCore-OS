using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TriCore_OS.Grafika;

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
            Registration registrUI = new Registration();



            
            registrUI.RegistrationUI();
            CenteringCursor();
            Username = Console.ReadLine();

            if (Username == null)
            {
                Console.WriteLine("Username Can not Be Empty");
            }
            PaswordEncrypting encrypting = new PaswordEncrypting();

            CenteringCursorPassword();

            SaveDetails(encrypting);
            Console.WriteLine("Registration Successful!");
            Process.Start(Environment.ProcessPath!);





        }
        public string EncryptedPass(PaswordEncrypting encrypting)
        {
            string EncrypptedPassword = encrypting.Encryption();
            return EncrypptedPassword;
        }


    

            private void CenteringCursor()
            {
                 int centerX = Console.WindowWidth / 2;
                 int centerY = Console.WindowHeight / 2;
                 int y = centerY + 1;
                 int x = Math.Max(0, centerX - 15);
                 Console.SetCursorPosition(x, y);
            }
        public void CenteringCursorPassword()
        {
            int centerX = Console.WindowWidth / 2;
            int centerY = Console.WindowHeight / 2;
            int y = centerY + 3;
            int x = Math.Max(0, centerX - 15);
            Console.SetCursorPosition(x, y);
        }

    }



    }




