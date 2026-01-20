using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.BabetaMaster
{
    public class ExchangeLightBulbs
    {
        public Player player;
        public void ExchangelightBulbs()
        {
            Thread.Sleep(3500);
            Console.Clear();
            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("System: Ako posledné musíš vymeniť žiarovky");
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
            Console.WriteLine("Systme: Vyber staré žiarovky");

            while (true)
            {
                char putoutoldbulbs = char.ToLower(Console.ReadKey(true).KeyChar);
                if (putoutoldbulbs == 'o')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 4);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 4);
                    Console.WriteLine("System: Vybral si staré žiarovky choď po nové");
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
                char gofornewbulbs = char.ToLower(Console.ReadKey(true).KeyChar);
                if (gofornewbulbs == 'w')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 5);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("System: Zober nové");
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }

            while (true)
            {
                char getnewbulbs = char.ToLower(Console.ReadKey(true).KeyChar);
                if (getnewbulbs == 'r')
                {
                    player.Inventory.Add("Žiarovky");
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 6);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 6);
                    Console.WriteLine("System: Choď naspäť ku babete a vymeň žiarovky");
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
                char gotobabeta = char.ToLower(Console.ReadKey(true).KeyChar);
                if (gotobabeta == 'w')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 7);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("System: Vymeň žiarovky");
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
                char openinv = char.ToLower(Console.ReadKey(true).KeyChar);
                if (openinv == 'e')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 8);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("INVENTÁR:");
                    Console.SetCursorPosition(5, 9);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 9);
                    player.Inventory.ForEach(Console.Write);
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
                char getbulbsonhand = char.ToLower(Console.ReadKey(true).KeyChar);
                if (getbulbsonhand == 'q')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 10);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 10);
                    Console.WriteLine("System: Žiarovky máš v ruke. Začni vymieňať");
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
                char replacebulbs = char.ToLower(Console.ReadKey(true).KeyChar);
                if (replacebulbs == 'o')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 11);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 11);
                    Console.WriteLine("System: Žiarovky si vymenil");
                    player.Inventory.Remove("Žiarovky");


                    int x1 = 95;
                    int y1 = 2;
                    for (int i = 0; i < player.RepairList.Count; i++)
                    {
                        Console.SetCursorPosition(x1, y1 + i);
                        Console.WriteLine(player.RepairList[i]);
                    }

                    if (player.RepairList.Count >= 5)
                    {
                        player.RepairList.RemoveAt(4);
                        player.RepairList.RemoveAt(2);
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
                    Console.SetCursorPosition(5, 11);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }
        }
    }
}
