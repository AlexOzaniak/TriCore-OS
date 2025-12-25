using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriCore_OS.Grafika;

namespace TriCore_OS.Login
{

    internal class FileRegistration : FileLogin
    {
        Registration reg = new Registration();
        public void RegisterDetails()
        {
            reg.RegistrationUI();
            CenteringCursor();
            Username = Console.ReadLine();
            
            if (Username == null)
            {
                Console.WriteLine("Username Can not Be Empty");
            }

            CenteringCursorPassword();

            Password = Console.ReadLine();
            if (Password == null)
            {
                Console.WriteLine("Password Can not Be Empty");
            }
            
            SaveDetails();
            Console.WriteLine("Registration Successful!");
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




