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
        private int positionX = 55;
        private int positionX2 = 35;
        private int positionY = 25;
        private string logo = nameof(LoadingUI); 
      

        private void LogoUI()
        {
            Console.SetCursorPosition(positionX2, 15);
            Console.WriteLine("    .---------.   .---------.   .---------.     .---------.   .---------.   .---------.");
            Console.SetCursorPosition(positionX2, 16);
            Console.WriteLine("   /  .-----.  \\ /  .-----.  \\ /  .-----.  \\   /  .-----.  \\ /  .-----.  \\ /  .-----.  \\");
            Console.SetCursorPosition(positionX2, 17);
            Console.WriteLine("  /  /       \\  V  /       \\  V  /       \\  \\ /  /       \\  V  /       \\  V  /       \\  \\");
            Console.SetCursorPosition(positionX2, 18);
            Console.WriteLine(" /__/_________\\___/_________\\___/_________\\__/__/_________\\___/_________\\___/_________\\__\\");
            Console.SetCursorPosition(positionX2, 19);
            Console.WriteLine("|     T R I    |    C O R E   |     O S      |      v2.5      |     L O A D I N G        |");
            Console.SetCursorPosition(positionX2, 20);
            Console.WriteLine("\\   \\       / /\\   \\       /  /\\ \\       /  /\\   \\       /  /\\  \\       /  /\\  \\       /  /");
            Console.SetCursorPosition(positionX2, 21);
            Console.WriteLine(" \\   '-----' /  \\   '-----'  /  \\ '-----'  /  \\   '-----'  /  \\  '-----'  /  \\  '-----'  /");
            Console.SetCursorPosition(positionX2, 22);
            Console.WriteLine("  '---------'    '---------'     '---------'    '---------'    '---------'    '---------'");


        }



        private void LoadingUI()
        {
            LogoUI();
            CursorPositionLoadning();
            Thread.Sleep(500);
            Console.Write("[░░░░░░░░░░░░░░░░]   0%  ─⊙─  Starting boot sequence");
            Thread.Sleep(500);
            Console.Clear();

            LogoUI();
            CursorPositionLoadning();
            Console.Write(" [██░░░░░░░░░░░░░░]  10%  ─⊙─  Initializing I/O");
            Thread.Sleep(700);
            Console.Clear();

            LogoUI();
            CursorPositionLoadning();
            Console.Write(" [████░░░░░░░░░░░░]  20%  ─⊙─  Loading core drivers");
            Thread.Sleep(400);
            Console.Clear();

            LogoUI();
            CursorPositionLoadning();
            Console.Write(" [██████░░░░░░░░░░]  30%  ─⊙─  Detecting hardware");
            Thread.Sleep(400);
            Console.Clear();

            LogoUI();
            CursorPositionLoadning();
            Console.Write(" [████████░░░░░░░░]  40%  ─⊙─  Mounting virtual FS");
            Thread.Sleep(400);
            Console.Clear();

            LogoUI();
            CursorPositionLoadning();
            Console.Write(" [██████████░░░░░░]  50%  ─⊙─  Launching services");
            Thread.Sleep(700);
            Console.Clear();
           
            LogoUI();
            CursorPositionLoadning();
            Console.Write("  [████████████░░░░]  60%  ─⊙─  Network stack online");
            Thread.Sleep(100);
            Console.Clear();
           
            LogoUI();
            CursorPositionLoadning();
            Console.Write(" [██████████████░░]  70%  ─⊙─  Security modules ready");
            Thread.Sleep(300);
            Console.Clear();
           
            LogoUI();
            CursorPositionLoadning();
            Console.Write(" [████████████████]  80%  ─⊙─  Optimizing system");
            Thread.Sleep(300);
            Console.Clear();
           
            LogoUI();
            CursorPositionLoadning();
            Console.Write(" [██████████████████░░]  90% ─⊙─  Preparing UI");
            Thread.Sleep(800);
            Console.Clear();
           
            LogoUI();
            CursorPositionLoadning();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" [████████████████████] 100% ─⊙─  TriCore ready!");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;
          
        }
        public void StartUI()
        {
            Console.CursorVisible = false;
            LoadingUI();
        }

        private void CursorPositionLoadning()
        {
            Console.SetCursorPosition(positionX, positionY);
        }
    }
}
