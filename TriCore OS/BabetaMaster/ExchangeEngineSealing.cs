using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.BabetaMaster
{
    public class ExchangeEngineSealing
    {
        public Player player;

        public void ExchangeengineSealing()
        {
            Thread.Sleep(3500);
            Console.Clear();
            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("System: Teraz musíš vymeniť tesnenie motora");
            int x = 95;
            int y = 2;
            Thread.Sleep(500);
            foreach (string line in player.RepairList)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(line);
                y++;
            }

            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("System: Vyber staré tesnenie");

            while (true)
            {
                char putoutoldsealing = char.ToLower(Console.ReadKey(true).KeyChar);
                if (putoutoldsealing == 'o')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 4);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 4);
                    Console.WriteLine("System: Vybral si staré tesnenie");
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 4);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }


            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("System: Choď po nové");

            while (true)
            {
                char gotonewsealing = char.ToLower(Console.ReadKey(true).KeyChar);
                if (gotonewsealing == 'w')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 6);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 6);
                    Console.WriteLine("System: Zober nové tesnenie");
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 6);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }

            while (true)
            {
                char getnewsealing = char.ToLower(Console.ReadKey(true).KeyChar);
                if (getnewsealing == 'r')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 7);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("System: Choď naspäť ku babete");
                    player.Inventory.Add("Tesnenie Motora");
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
                char gotobabeta = char.ToLower(Console.ReadKey(true).KeyChar);
                if (gotobabeta == 'w')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 8);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("System: Si pri babete môžeš vymieňať tesnenie");
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }

            while (true)
            {
                char openinv = char.ToLower(Console.ReadKey(true).KeyChar);
                if (openinv == 'e')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 9);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine("INVENTÁR:");
                    Console.SetCursorPosition(5, 10);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 10);
                    player.Inventory.ForEach(Console.Write);
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }

            while (true)
            {
                char getringonhand = char.ToLower(Console.ReadKey(true).KeyChar);
                if (getringonhand == 'q')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 11);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 11);
                    Console.WriteLine("System: Tesnenie máš v ruke");
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
                char exchangesealing = char.ToLower(Console.ReadKey(true).KeyChar);
                int x1 = 95;
                int y1 = 2;
                if (exchangesealing == 'o')
                {
                    Thread.Sleep(3500);
                    Console.SetCursorPosition(5, 12);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 12);
                    Console.WriteLine("System: Tesnenie si vymenil");
                    player.Inventory.Remove("Tesnenie Motora");
                    for (int i = 0; i < player.RepairList.Count; i++)
                    {
                        Console.SetCursorPosition(x1, y1 + i);
                        Console.WriteLine(player.RepairList[i]);
                    }

                    if (player.RepairList.Count >= 3)
                    {
                        player.RepairList.RemoveAt(2);
                        player.RepairList.RemoveAt(1);
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
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 12);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }
        }
    }
}
