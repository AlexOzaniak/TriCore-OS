using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.BabetaMaster
{
    public class ExchangePiston
    {
        public Player player;
        public void PistonExchange()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.SetCursorPosition(5, 2);
            Console.WriteLine("System: Pokračuj podľa zoznamu ako včera");
            int x = 95;
            int y = 2;
            Thread.Sleep(500);
            foreach (string line in player.RepairList)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(line);
                y++;
            }
            Console.SetCursorPosition(5, 3);
            Thread.Sleep(2500);
            Console.WriteLine("System: Čaká ťa výmena piestu");
            Console.SetCursorPosition(5, 4);
            Thread.Sleep(2500);
            Console.WriteLine("System: Vyber starý piest");
            while (true)
            {
                char putoutpiston = char.ToLower(Console.ReadKey(true).KeyChar);
                if (putoutpiston == 'o')
                {
                    Thread.Sleep(4500);
                    Console.SetCursorPosition(5, 5);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("System: Vytiahol si starý piest");
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }

            Console.SetCursorPosition(5, 6);
            Thread.Sleep(2500);
            Console.WriteLine("System: Choď ku stole po nový");

            while (true)
            {
                char gototable = char.ToLower(Console.ReadKey(true).KeyChar);
                if (gototable == 'w')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 7);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("System: Si pri stole, zober piest");
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }

            while (true)
            {
                char putpistonininv = char.ToLower(Console.ReadKey(true).KeyChar);
                if (putpistonininv == 'r')
                {

                    player.Inventory.Add("Piest");
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 8);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("System: Piest máš v inventári");
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }
            Console.SetCursorPosition(5, 9);
            Thread.Sleep(2500);
            Console.WriteLine("System: Choď naspäť ku babete");
            while (true)
            {
                char gotobabeta = char.ToLower(Console.ReadKey(true).KeyChar);
                if (gotobabeta == 'w')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 10);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 10);
                    Console.WriteLine("System: Si pri babete a môžeš tam dávať nový piest");
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 10);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }

            while (true)
            {
                char openinv = char.ToLower(Console.ReadKey(true).KeyChar);
                if (openinv == 'e')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 11);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 11);
                    Console.WriteLine("INVENTÁR:");
                    Console.SetCursorPosition(5, 12);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 12);
                    player.Inventory.ForEach(Console.Write);
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 11);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }

            while (true)
            {
                char putpistoninhand = char.ToLower(Console.ReadKey(true).KeyChar);
                if (putpistoninhand == 'q')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 13);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 13);
                    Console.WriteLine("System: Piest máš v ruke možeš ho tam dať");
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 13);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }

            while (true)
            {
                char putpistoninbabeta = char.ToLower(Console.ReadKey(true).KeyChar);
                if (putpistoninbabeta == 'o')
                {
                    Thread.Sleep(4000);
                    Console.SetCursorPosition(5, 14);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 14);
                    Console.WriteLine("System: Piest si tam úspešne vložil");
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 14);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }

            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 15);
            Console.WriteLine("System: Odlož náradie,ktoré si použil");
            int x1 = 95;
            int y1 = 2;
            while (true)
            {
                char puttoolsback = char.ToLower(Console.ReadKey(true).KeyChar);
                if (puttoolsback == 'r')
                {
                    for (int i = 0; i < player.RepairList.Count; i++)
                    {
                        Console.SetCursorPosition(x1, y1 + i);
                        Console.WriteLine(player.RepairList[i]);
                    }

                    if (player.RepairList.Count >= 4)
                    {
                        player.RepairList.RemoveAt(3);
                    }

                    for (int i = 0; i < 20; i++)
                    {
                        Console.SetCursorPosition(x1, y1 + i);
                        Console.Write(new string(' ', 50));
                    }

                    for (int i = 0; i < player.RepairList.Count; i++)
                    {
                        Console.SetCursorPosition(x1, y1 + i);
                        Console.WriteLine(player.RepairList[i]);
                    }

                    Thread.Sleep(2500);
                    Console.SetCursorPosition(5, 16);
                    Console.WriteLine("System: Náradie si odložil");
                    player.Inventory.Remove("Piest");
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 15);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }
        }
            
    }
}
