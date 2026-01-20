using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.BabetaMaster
{
    public class Day3
    {
        public MusicPlayer music;
        public void day3()
        {
            Console.Clear();
            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("Čas: 10:00");
            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 10);
            Console.WriteLine("Ty: .........");
            Thread.Sleep(3000);
            Console.Clear();
            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("Čas: 10:30");
            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("System: Vstal si");
            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("System: Si sám doma. Ideš sa naraňajkovať");
            Thread.Sleep(3000);
            Console.Clear();

            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("Čas: 11:00");
            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("System: Naraňajkoval si sa a ideš štartovať babetu");
            Thread.Sleep(3000);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("System: Si v garáži choď ku babete");

            while (true)
            {
                char gotobabeta = char.ToLower(Console.ReadKey(true).KeyChar);
                if (gotobabeta == 'w')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 3);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 3);
                    Console.WriteLine("System: Si pri babete naštartuj ju");
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 3);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }

            while (true)
            {
                char startbabeta = char.ToLower(Console.ReadKey(true).KeyChar);
                if (startbabeta == 'd')
                {
                    music = new MusicPlayer();
                    music.Play("Davidstart.wav");
                    Thread.Sleep(9000);
                    Console.SetCursorPosition(5, 4);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 4);
                    Console.WriteLine("System: Babetu si naštartoval. Môžeš sa isť odviesť");
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 4);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }

            while (true)
            {
                char goriding = char.ToLower(Console.ReadKey(true).KeyChar);
                if (goriding == 'w')
                {
                    Console.Clear();
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(70, 20);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(70, 20);
                    Console.Write("Jazdíš");
                    music = new MusicPlayer();
                    music.Play("Jazda.wav");
                    for (int i = 0; i < 15; i++)
                    {
                        Thread.Sleep(300);
                        Console.SetCursorPosition(79 + i, 20);
                        Console.Write(".");
                    }
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(70, 20);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }

            Console.Clear();
            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("Čas: 13:00");
            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("System: Dojazdil si");
        }
    }
}
