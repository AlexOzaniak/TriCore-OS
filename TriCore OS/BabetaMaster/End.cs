using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.BabetaMaster
{
    public class End
    {
        Menu menu = new Menu();
        public void end()
        {
            Thread.Sleep(3000);
            Console.Clear();
            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("System: Ďakujem za zahratie hry");
            Thread.Sleep(2500);
            Console.Clear();
            Thread.Sleep(2500);
            Console.SetCursorPosition(70, 20);
            Console.Write("Returning to the menu");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(300);
                Console.SetCursorPosition(92 + i, 20);
                Console.Write(".");
            }
            menu.menu();
        }
    }
}
