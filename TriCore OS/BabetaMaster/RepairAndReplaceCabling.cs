using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.BabetaMaster
{
    public class RepairAndReplaceCabling
    {
        public Player player;
        public void RepairReplaceCabling()
        {
            Thread.Sleep(3500);
            Console.Clear();
            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("System: Super už ideš do finále");
            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("System: Musíš opraviť a vymeniť kabeláž");
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
            Console.WriteLine("System: Vyber starú kabeláž");

            while (true)
            {
                char putoutoldcabling = char.ToLower(Console.ReadKey(true).KeyChar);
                if (putoutoldcabling == 'o')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 5);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("System: Vybral si starú kabeláž. Teraz ju oprav");
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
                char repaircabling = char.ToLower(Console.ReadKey(true).KeyChar);
                if (repaircabling == 'o')
                {
                    Thread.Sleep(3000);
                    Console.SetCursorPosition(5, 6);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 6);
                    Console.WriteLine("System: Kabeláž si opravil. Teraz ju daj naspäť");
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
                char putcablingin = char.ToLower(Console.ReadKey(true).KeyChar);
                if (putcablingin == 'o')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 7);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("System: Kabeláž si dal naspäť");
                    int x1 = 95;
                    int y1 = 2;
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
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("System: Skús inú klávesu.");
                }
            }
        }
    }
}
