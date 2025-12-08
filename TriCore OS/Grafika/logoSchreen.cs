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
       private string logoScreen = @"
   .----.  .----.  .----.   .----.  .----.  .----.
  /  /\  \/  /\  \/  /\  \ /  /\  \/  /\  \/  /\  \
 /__/_/___\_/__\_/__/_/___\_/__/_/___\_/__\_/__/_/__\
 |  TRI  |  CORE  |   O S   |   v2.5   |  LOADING   |
 \  \/  /\/  \/  /\/  \/  /\/  \/  /\/  \/  /\/  \/  /
  '----'  '----'  '----'   '----'  '----'  '----'
";
        private void PositionUI()
        {
            try
            {
                string[,] matrix = new string[40, 40];
                Console.SetCursorPosition(10, 5);
                //int yPos = 10;
                //int xPos = 40;
                //int dlzka = logoScreen.Length + logo.Length;
                //int StartX = (Console.WindowWidth / 2) - (xPos / 2);
                //int StartY = (Console.WindowHeight / 2) + (yPos / 2) + 1;
                //int update = StartX + logoScreen.Length;
                //Console.SetCursorPosition(StartX, StartY);
                
            }
            catch
            {
                Console.Write("BUG");
            }
        }
      

        private void LogoUI()
        {
           
            Console.Write(spaces + logoScreen);

        }



        private void LoadingUI()
        {
            PositionUI();
            LogoUI();
            Thread.Sleep(500);
            Console.Write("[░░░░░░░░░░░░░░░░]   0%  ─⊙─  Starting boot sequence");
            Thread.Sleep(500);
           
            PositionUI();
            LogoUI();
            Console.Write(" [██░░░░░░░░░░░░░░]  10%  ─⊙─  Initializing I/O");
            Thread.Sleep(700);
            
            PositionUI();
            LogoUI();
            Console.Write(" [████░░░░░░░░░░░░]  20%  ─⊙─  Loading core drivers");
            Thread.Sleep(400);
           
            PositionUI();
            LogoUI();
            Console.Write("[██████░░░░░░░░░░]  30%  ─⊙─  Detecting hardware");
            Thread.Sleep(400);
           
            PositionUI();
            LogoUI();
            Console.Write(" [████████░░░░░░░░]  40%  ─⊙─  Mounting virtual FS");
            Thread.Sleep(400);
            
            PositionUI();
            LogoUI();
            Console.Write(" [██████████░░░░░░]  50%  ─⊙─  Launching services");
            Thread.Sleep(700);
           
            PositionUI();
            LogoUI();
            Console.Write("  [████████████░░░░]  60%  ─⊙─  Network stack online");
            Thread.Sleep(100);
           
            PositionUI();
            LogoUI();
            Console.Write(" [██████████████░░]  70%  ─⊙─  Security modules ready");
            Thread.Sleep(300);
           
            PositionUI();
            LogoUI();
            Console.Write(" [████████████████]  80%  ─⊙─  Optimizing system");
            Thread.Sleep(300);
           
            PositionUI();
            LogoUI();
            Console.Write(" [██████████████████░░]  90% ─⊙─  Preparing UI");
            Thread.Sleep(800);
           
            PositionUI();
            LogoUI();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" [████████████████████] 100% ─⊙─  TriCore ready!");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Black;
          
        }
        public void StartUI()
        {
            Console.CursorVisible = false;
            LoadingUI();
        }
    }
}
