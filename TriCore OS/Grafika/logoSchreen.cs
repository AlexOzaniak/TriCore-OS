using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TriCore_OS.Grafika
{
    internal class logoSchreen
    {
        private string spaces = new string(' ', 20);
        private string logo = nameof(LoadingUI); 
      

        private void LogoUI()
        {
            Console.SetCursorPosition(50, 5);
            Console.WriteLine(" .----.  .----.  .----.   .----.  .----.  .----.");
            Console.SetCursorPosition(50, 6);
            Console.WriteLine("/  /\\  \\/  /\\  \\/  /\\  \\ /  /\\  \\/  /\\  \\/  /\\  \\");
            Console.SetCursorPosition(50, 7);
            Console.WriteLine("/__/_/___\\_/__\\_/__/_/___\\_/__/_/___\\_/__\\_/__/_/__\\");
            Console.SetCursorPosition(50, 8);
            Console.WriteLine("|  TRI  |  CORE  |   O S   |   v2.5   |  LOADING   |");
            Console.SetCursorPosition(50, 9);
            Console.WriteLine("\\  \\/  /\\/  \\/  /\\/  \\/  /\\/  \\/  /\\/  \\/  /\\/  \\/  /");
            Console.SetCursorPosition(50, 10);
            Console.WriteLine(" '----'  '----'  '----'   '----'  '----'  '----'");
            Console.SetCursorPosition(50, 11);
            

        }



        private void LoadingUI()
        {
            Console.SetCursorPosition(50, 14);
            LogoUI();
            Thread.Sleep(500);
            Console.WriteLine("[░░░░░░░░░░░░░░░░]   0%  ─⊙─  Starting boot sequence");
            Thread.Sleep(500);
            Console.Clear();

            Console.SetCursorPosition(50, 15);
            LogoUI();
            Console.WriteLine(" [██░░░░░░░░░░░░░░]  10%  ─⊙─  Initializing I/O");
            Thread.Sleep(700);
            Console.Clear();
            
            Console.SetCursorPosition(50, 15);
            LogoUI();
            Console.WriteLine(" [████░░░░░░░░░░░░]  20%  ─⊙─  Loading core drivers");
            Thread.Sleep(400);
            Console.Clear();
           
            LogoUI();
            Console.SetCursorPosition(50, 11);
            Console.WriteLine(" [██████░░░░░░░░░░]  30%  ─⊙─  Detecting hardware");
            Thread.Sleep(400);
            Console.Clear();
           
            Console.SetCursorPosition(50, 15);
            LogoUI();
            Console.WriteLine(" [████████░░░░░░░░]  40%  ─⊙─  Mounting virtual FS");
            Thread.Sleep(400);
            Console.Clear();
            
            Console.SetCursorPosition(50, 15);
            LogoUI();
            Console.WriteLine(" [██████████░░░░░░]  50%  ─⊙─  Launching services");
            Thread.Sleep(700);
            Console.Clear();
           
            Console.SetCursorPosition(50, 15);
            LogoUI();
            Console.WriteLine("  [████████████░░░░]  60%  ─⊙─  Network stack online");
            Thread.Sleep(100);
            Console.Clear();
           
            Console.SetCursorPosition(50, 15);
            LogoUI();
            Console.WriteLine(" [██████████████░░]  70%  ─⊙─  Security modules ready");
            Thread.Sleep(300);
            Console.Clear();
           
            Console.SetCursorPosition(50, 15);
            LogoUI();
            Console.WriteLine(" [████████████████]  80%  ─⊙─  Optimizing system");
            Thread.Sleep(300);
            Console.Clear();
           
            Console.SetCursorPosition(50, 15);
            LogoUI();
            Console.WriteLine(" [██████████████████░░]  90% ─⊙─  Preparing UI");
            Thread.Sleep(800);
            Console.Clear();
           
            Console.SetCursorPosition(50, 15);
            LogoUI();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" [████████████████████] 100% ─⊙─  TriCore ready!");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;
          
        }
        public void StartUI()
        {
            Console.CursorVisible = false;
            LoadingUI();
        }

        
    }
}
