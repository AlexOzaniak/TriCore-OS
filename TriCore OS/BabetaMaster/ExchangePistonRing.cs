using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.BabetaMaster
{
    public class ExchangePistonRing
    {
        public Player player;
        public void ExchangepistonRing()
        {
            Thread.Sleep(3500);
            Console.Clear();
            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("System: Super zvládol si výmenu piestu");
            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("System: Teraz ťa čaká výmena piestneho krúžku");
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
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("System: Choď po nový krúžok");

            while (true)
            {
                char gotonewring = char.ToLower(Console.ReadKey(true).KeyChar);
                if (gotonewring == 'w')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 5);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("System: Zober nový krúžok");
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
                char getnewring = char.ToLower(Console.ReadKey(true).KeyChar);
                if (getnewring == 'r')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 6);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 6);
                    Console.WriteLine("System: Zobral si nový krúžok");
                    player.Inventory.Add("Piestny Krúžok");
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 6);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }

            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("System: Choď naspäť ku babete");

            while (true)
            {
                char gotobabeta = char.ToLower(Console.ReadKey(true).KeyChar);
                if (gotobabeta == 'w')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 8);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("System: Si pri babete môžeš začať vymienať");
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
                    Console.WriteLine("System: Krúžok máš v ruke začni ho vymieňať");
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
                char exchangering = char.ToLower(Console.ReadKey(true).KeyChar);
                if (exchangering == 'o')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 12);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 12);
                    Console.WriteLine("System: Vymenil si piestny krúžok");
                    player.Inventory.Remove("Piestny Krúžok");

                    int x1 = 95;
                    int y1 = 2;
                    for (int i = 0; i < player.RepairList.Count; i++)
                    {
                        Console.SetCursorPosition(x1, y1 + i);
                        Console.WriteLine(player.RepairList[i]);
                    }

                    if (player.RepairList.Count >= 3)
                    {
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
                    Console.SetCursorPosition(5, 12);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }
        }
    }
}
