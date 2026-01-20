using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.BabetaMaster
{
    public class ExchangeFuelPipe
    {
        public Player player;
       public void ExchangefuelPipe()
        {
            int x = 95;
            int y = 2;
            Thread.Sleep(3500);
            Console.Clear();
            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("System: Teraz ťa čaká výmena palivovej hadičky");

            Thread.Sleep(500);
            for (int i = 0; i < player.RepairList.Count; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(player.RepairList[i]);
            }

            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("System: Choď  ku stole po kombinačky");

            while (true)
            {
                char go = char.ToLower(Console.ReadKey(true).KeyChar);
                if (go == 'w')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 4);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 4);
                    Console.WriteLine("System: Si pri stole a zober kombinačky");
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
                char takepliers = char.ToLower(Console.ReadKey(true).KeyChar);
                if (takepliers == 'r')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 5);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 5);
                    player.Inventory.Add("Kombinačky");
                    Console.WriteLine("System: Kombinačky máš v inventári");
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
            Console.WriteLine("System: Choď naspäť ku babete");

            while (true)
            {
                char gotobabeta = char.ToLower(Console.ReadKey(true).KeyChar);
                if (gotobabeta == 'w')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 7);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("System: Si pri babete. Otvor inventár, zober kombinačky do ruky a začni vymieňať hadičku");
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
                char takepliersonhand = char.ToLower(Console.ReadKey(true).KeyChar);
                if (takepliersonhand == 'q')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 10);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 10);
                    Console.WriteLine("System: Kombinačky máš v ruke");
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 10);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }

            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 11);
            Console.WriteLine("System: Začni vymieňať hadičku");
            while (true)
            {
                char repairingpipe = char.ToLower(Console.ReadKey(true).KeyChar);
                if (repairingpipe == 'o')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 12);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 12);
                    Console.WriteLine("System: Hadičku si vymenil");
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 12);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }


            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 13);
            Console.WriteLine("System: Odlož kombinačky na svoje miesto");
            int x1 = 95;
            int y1 = 2;
            while (true)
            {
                char postponepliers = char.ToLower(Console.ReadKey(true).KeyChar);
                if (postponepliers == 'r')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 14);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 14);
                    Console.WriteLine("System: Kombinačky si vrátil na miesto");
                    player.Inventory.Remove("Kombinačky");
                    for (int i = 0; i < player.RepairList.Count; i++)
                    {
                        Console.SetCursorPosition(x1, y1 + i);
                        Console.WriteLine(player.RepairList[i]);
                    }

                    if (player.RepairList.Count >= 2)
                    {
                        player.RepairList.RemoveAt(1);
                        player.RepairList.RemoveAt(0);
                    }
                    else if (player.RepairList.Count == 2)
                    {
                        player.RepairList.RemoveAt(0);
                        player.RepairList.RemoveAt(1);
                    }

                    for (int i = 0; i < 20; i++)
                    {
                        Console.SetCursorPosition(x1, y1 + i);
                        Console.WriteLine(new string(' ', 50));
                    }

                    for (int i = 0; i < player.RepairList.Count; i++)
                    {
                        Console.SetCursorPosition(x1, y1 + i);
                        Console.WriteLine(player.RepairList[i]);
                    }

                    Thread.Sleep(2500);
                    Console.SetCursorPosition(5, 16);
                    Console.WriteLine("System: Dokončil si základnú údržbu");
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 14);
                    Console.WriteLine("System: Skús inú klávesu.");
                }                   
            }
        }
    }
}
