using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TriCore_OS.Grafika
{
    internal class logoSchreen
    {
       private string logoScreen = @"
   .----.  .----.  .----.   .----.  .----.  .----.
  /  /\  \/  /\  \/  /\  \ /  /\  \/  /\  \/  /\  \
 /__/_/___\_/__\_/__/_/___\_/__/_/___\_/__\_/__/_/__\
 |  TRI  |  CORE  |   O S   |   v2.5   |  LOADING   |
 \  \/  /\/  \/  /\/  \/  /\/  \/  /\/  \/  /\/  \/  /
  '----'  '----'  '----'   '----'  '----'  '----'
";
        private string PositionUI()
        {
              int withConsole = Console.WindowWidth;
             int heightConsole = Console.WindowHeight;
            int xPos = 3;
            int yPos = 10;
            Console.SetCursorPosition(xPos, yPos);
            return PositionUI();
        }
      

        private void LogoUI()
        {
           
            Console.Write(logoScreen);

        }



        private void LoadingUI()
        {
            PositionUI();
            LogoUI();
            Thread.Sleep(500);
            Console.WriteLine("[░░░░░░░░░░░░░░░░]   0%  ─⊙─  Starting boot sequence");
            Thread.Sleep(500);
            Console.Clear();
            PositionUI(); 
            LogoUI();
            Console.WriteLine(" [██░░░░░░░░░░░░░░]  10%  ─⊙─  Initializing I/O");
            Thread.Sleep(700);
            Console.Clear();
            PositionUI();
            LogoUI();
            Console.WriteLine(" [████░░░░░░░░░░░░]  20%  ─⊙─  Loading core drivers");
            Thread.Sleep(400);
            Console.Clear();
            PositionUI();
            LogoUI();
            Console.WriteLine("[██████░░░░░░░░░░]  30%  ─⊙─  Detecting hardware");
            Thread.Sleep(400);
            Console.Clear();
            PositionUI();
            LogoUI();
            Console.WriteLine(" [████████░░░░░░░░]  40%  ─⊙─  Mounting virtual FS");
            Thread.Sleep(400);
            Console.Clear();
            PositionUI();
            LogoUI();
            Console.WriteLine(" [██████████░░░░░░]  50%  ─⊙─  Launching services");
            Thread.Sleep(700);
            Console.Clear();
            PositionUI();
            LogoUI();
            Console.WriteLine("  [████████████░░░░]  60%  ─⊙─  Network stack online");
            Thread.Sleep(100);
            Console.Clear();
            PositionUI();
            LogoUI();
            Console.WriteLine(" [██████████████░░]  70%  ─⊙─  Security modules ready");
            Thread.Sleep(300);
            Console.Clear();
            PositionUI();
            LogoUI();
            Console.WriteLine(" [████████████████]  80%  ─⊙─  Optimizing system");
            Thread.Sleep(300);
            Console.Clear();
            PositionUI();
            LogoUI();
            Console.WriteLine(" [██████████████████░░]  90% ─⊙─  Preparing UI");
            Thread.Sleep(800);
            Console.Clear();
            PositionUI();
            LogoUI();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" [████████████████████] 100% ─⊙─  TriCore ready!");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
        }
        public void StartUI()
        {
            LoadingUI();
        }
    }
}
