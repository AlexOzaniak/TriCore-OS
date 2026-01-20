using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.BabetaMaster
{
    public class ExchangeSparkPlug
    {
        public Player player;
        public void ExchangePlug()
        {
            Thread.Sleep(5000);

            Console.Clear();
            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("System: Ideš ku svojej babete");
            Console.SetCursorPosition(5, 3);
            Thread.Sleep(2500);
            Console.WriteLine("System: Postupuj podľa uvedeného zoznamu");
            Thread.Sleep(2500);

            int x = 95;
            int y = 2;
            foreach (string line in player.RepairList)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(line);
                y++;
            }


            Console.SetCursorPosition(5, 4);
            Thread.Sleep(2500);
            Console.WriteLine("System: Zober kľúč na uvoľnenie sviečky");
            while (true)
            {
                char inputplug = char.ToLower(Console.ReadKey(true).KeyChar);
                if (inputplug == 'r')

                {
                    player.Inventory.Add("6-uholníkový kľúč");
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 5);
                    Console.Write(new string(' ', 40));
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("System: Zobral si kľúč do inventára");
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }




            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 6);
            Console.WriteLine("System: Choď ku babete");
            while (true)
            {
                char inputgotobabeta = char.ToLower(Console.ReadKey(true).KeyChar);
                if (inputgotobabeta == 'w')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 7);
                    Console.Write(new string(' ', 40));
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("System: Si pri babete");
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }

            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 8);
            Console.WriteLine("System: Otvor inventár a zober kľúč");
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
                char grabkey = char.ToLower(Console.ReadKey(true).KeyChar);
                if (grabkey == 'q')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 11);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 11);
                    Console.WriteLine("System: Kľúč máš v ruke");
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 11);
                    Console.WriteLine("System: Skús inú klávesu.");

                }
            }

            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 12);
            Console.WriteLine("System: Začni povoľovať sviečku");
            while (true)
            {
                char inputplugrelease = char.ToLower(Console.ReadKey(true).KeyChar);
                if (inputplugrelease == 'o')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 13);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 13);
                    Console.WriteLine("System: Uvoľnil si a vybral si sviečku");
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 13);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }

            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 14);
            Console.WriteLine("System: Daj tam novú sviečku");
            while (true)
            {
                char newplug = char.ToLower(Console.ReadKey(true).KeyChar);
                if (newplug == 'o')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 15);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 15);
                    Console.WriteLine("System: Sviečku si vymenil");
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 15);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }

            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 16);
            Console.WriteLine("System: Odlož 6-uholníkový kľúč na svoje miesto");

            int x2 = 95;
            int y2 = 2;
            while (true)
            {
                char postponekey = char.ToLower(Console.ReadKey(true).KeyChar);
                if (postponekey == 'r')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 17);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("System: Kľúč si odložil na svoje miesto");
                    player.Inventory.Remove("6-uholníkový kľúč");
                    for (int i = 0; i < player.RepairList.Count; i++)
                    {
                        Console.SetCursorPosition(x2, y2 + i);
                        Console.WriteLine(player.RepairList[i]);
                    }

                    if (player.RepairList.Count >= 2)
                    {
                        player.RepairList.RemoveAt(1);
                    }

                    for (int i = 0; i < 20; i++)
                    {
                        Console.SetCursorPosition(x2, y2 + i);
                        Console.WriteLine(new string(' ', 50));
                    }

                    for (int i = 0; i < player.RepairList.Count; i++)
                    {
                        Console.SetCursorPosition(x2, y2 + i);
                        Console.WriteLine(player.RepairList[i]);
                    }
                    break;
                }                
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
              
            }
        }
    }
}

