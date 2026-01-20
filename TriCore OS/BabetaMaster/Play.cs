using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace TriCore_OS.BabetaMaster
{
    internal class Play
    {
       
        //Menu menu = new Menu();
        StartGame startGame = new StartGame();
        ToDoList list = new ToDoList();
        ExchangeFuelPipe pipe = new ExchangeFuelPipe();
        Sleep sleep = new Sleep();
        Day2 day2 = new Day2();
        ExchangePiston piston = new ExchangePiston();
        ExchangePistonRing ring = new ExchangePistonRing();
        RepairAndReplaceCabling cabling = new RepairAndReplaceCabling();
        ExchangeLightBulbs bulbs = new ExchangeLightBulbs();
        ExchangeEngineSealing sealing = new ExchangeEngineSealing();
        End end = new End();
        Day1 day1 = new Day1();
        Day3 day3 = new Day3();
        public Player player;
        private MusicPlayer music;
        //public void Loading()
        //{
        //    Player player = new Player();

        //    day1.player = player;
        //    sealing.player = player;
        //    pipe.player = player;
        //    bulbs.player = player;
        //    piston.player = player;
        //    ring.player = player;
        //    cabling.player = player;
        //    list.player = player;

        //    startGame.GameStart();
        //    bool startGameFromMenu = menu.menu();

        //    if (startGameFromMenu)
        //    {
        //        day1.Morningday1();
        //        list.ReadToDoList();
               
        //        pipe.ExchangefuelPipe();
        //        Console.Clear();
        //        Thread.Sleep(1000);
        //        Thread.Sleep(200);
        //        Console.SetCursorPosition(70, 20);
        //        Console.Write("Loading");
        //        for (int i = 0; i < 10; i++)
        //        {
        //            Thread.Sleep(300);
        //            Console.SetCursorPosition(79 + i, 20);
        //            Console.Write(".");

        //        }
        //    }

        //}
        public void PlayGame()                  //toto treba sputit aby sa hra zapla  
        {
            player = new Player();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            void Morning()
            {
                Console.SetCursorPosition(5, 2);
                Console.WriteLine("Čas: 7:00 ");
                Console.SetCursorPosition(5, 10);
                Thread.Sleep(1500);
                Console.WriteLine("Mama: David stávaj!");
                Console.SetCursorPosition(5, 11);
                Thread.Sleep(1500);
                Console.WriteLine("Ty: ........");
                Console.SetCursorPosition(5, 12);
                Thread.Sleep(1500);
                Console.WriteLine("Mama: Nepočul si stávaj!");
                Console.SetCursorPosition(5, 13);
                Thread.Sleep(1500);
                Console.WriteLine("Ty: Veď už idem");
                Thread.Sleep(3000);

                Console.Clear();
                Console.SetCursorPosition(5, 2);
                Console.WriteLine("Čas: 7:30 ");
                Thread.Sleep(1500);
                Console.SetCursorPosition(5, 3);
                Console.WriteLine("System: Vstal si a ideš sa naraňajkovať");
                Thread.Sleep(3500);
                Console.SetCursorPosition(5, 10);
                Thread.Sleep(1500);
                Console.WriteLine("Ty: Čau tata");
                Console.SetCursorPosition(5, 11);
                Thread.Sleep(1500);
                Console.WriteLine("Otec: Nazdar, už si mal byť zobudený pred hodinou. Ideš pomáhať s drevom");
                Console.SetCursorPosition(5, 12);
                Thread.Sleep(1500);
                Console.WriteLine("Ty: To zas ? Šak minule sme rezali drevo.");
                Console.SetCursorPosition(5, 13);
                Thread.Sleep(1500);
                Console.WriteLine("Otec: Jak zas. Ide zima tak treba mať s čím kúriť.");
                Console.SetCursorPosition(5, 14);
                Thread.Sleep(1500);
                Console.WriteLine("Otec: Tak sa naraňajkuj a pôjdeme.");
                Console.SetCursorPosition(5, 15);
                Thread.Sleep(1500);
                Console.WriteLine("Ty: No okej");
                Thread.Sleep(2500);

                Console.Clear();
                Console.SetCursorPosition(5, 2);
                Console.WriteLine("Čas: 8:00 ");
                Thread.Sleep(1500);
                Console.SetCursorPosition(5, 3);
                Console.WriteLine("System: Naraňajkoval si sa a ideš s otcom rezať drevo.");

                Console.SetCursorPosition(5, 10);
                Thread.Sleep(1500);
                Console.WriteLine("Otec: Zober motorovku ja zoberem sekeru a benzín");
                Console.SetCursorPosition(5, 11);
                Thread.Sleep(1500);
                Console.WriteLine("Ty: No ja už idem ku drevu");
                Console.SetCursorPosition(5, 12);
                Thread.Sleep(1500);
                Console.WriteLine("Otec: Dobre počkaj ma tam");
                Console.SetCursorPosition(5, 13);
                Thread.Sleep(1500);
                Console.WriteLine("Ty: Kde je ten otec toľko. Nebudem tu tak dlho čakať");
                Console.SetCursorPosition(5, 14);
                Thread.Sleep(3000);
                Console.WriteLine("Ty: No konečne si tu.");
                Console.SetCursorPosition(5, 15);
                Thread.Sleep(1500);
                Console.WriteLine("Otec: Daj mi tu pílu a ideme to rezať");
                music = new MusicPlayer();
                music.Play("Motorovka.wav");

                Thread.Sleep(13000);
                Console.Clear();
                Console.SetCursorPosition(5, 2);
                Console.WriteLine("Čas: 12:00");
                Thread.Sleep(1500);
                Console.SetCursorPosition(5, 3);
                Console.WriteLine("System: Dorezali ste drevo");
                Thread.Sleep(1500);
                Console.SetCursorPosition(5, 4);
                Console.WriteLine("System: Idete sa naobedovať");
                Thread.Sleep(3000);
            }
            Morning();

            void RepairList()
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.Clear();
                Console.SetCursorPosition(5, 2);
                Console.WriteLine("Čas: 13:00");
                Thread.Sleep(1500);
                Console.SetCursorPosition(5, 3);
                Console.WriteLine("System: Naobedoval si sa");
                Thread.Sleep(1500);
                Console.SetCursorPosition(5, 4);
                Console.WriteLine("System: Ideš do garáže opravovať babetu");
                Thread.Sleep(2000);
                Console.SetCursorPosition(5, 5);
                Console.WriteLine("System: Na stole je zoznam oprav, ktoré musíš urobiť");
                Thread.Sleep(1500);
                Console.SetCursorPosition(5, 6);
                Console.WriteLine("System: Otvor zoznam");

                string path = @"C:\Users\smrzo\Desktop\To-Do List.txt";
                player.RepairList = File.ReadAllLines(path).ToList();
                char input = char.ToLower(Console.ReadKey(true).KeyChar);
                if (input == 'l')
                {
                    int x1 = 5;
                    int y1 = 8;
                    foreach (string line in player.RepairList)
                    {
                        Console.SetCursorPosition(x1, y1);
                        Console.WriteLine(line);
                        y1++;
                    }
                }

                Thread.Sleep(5000);

                Console.Clear();
                Thread.Sleep(1500);
                Console.SetCursorPosition(5, 2);
                Console.WriteLine("System: Ideš ku svojej babete");
                Console.SetCursorPosition(5, 3);
                Thread.Sleep(1500);
                Console.WriteLine("System: Postupuj podľa uvedeného zoznamu");
                Thread.Sleep(1500);
                int x = 95;
                int y = 2;
                foreach (string line in player.RepairList)
                {
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine(line);
                    y++;
                }
            }
            RepairList();

            void ExchangeSparkPlug()
            {
                Console.SetCursorPosition(5, 4);
                Thread.Sleep(1500);
                Console.WriteLine("System: Zober kľúč na uvoľnenie sviečky");
                char inputplug = char.ToLower(Console.ReadKey(true).KeyChar);
                if (inputplug == 'r')
                {
                    player.Inventory.Add("6-uholníkový kľúč");
                    Thread.Sleep(1500);
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("System: Zobral si kľúč do inventára");
                }

                Thread.Sleep(1500);
                Console.SetCursorPosition(5, 6);
                Console.WriteLine("System: Choď ku babete");
                char inputgotobabeta = char.ToLower(Console.ReadKey(true).KeyChar);
                if (inputgotobabeta == 'w')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("System: Si pri babete");
                }

                Thread.Sleep(1500);
                Console.SetCursorPosition(5, 8);
                Console.WriteLine("System: Otvor inventár a zober kľúč");
                char openinv = char.ToLower(Console.ReadKey(true).KeyChar);
                if (openinv == 'e')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine("INVENTÁR:");
                    Console.SetCursorPosition(5, 10);
                    player.Inventory.ForEach(Console.Write);
                }
                char grabkey = char.ToLower(Console.ReadKey(true).KeyChar);
                if (grabkey == 'q')
                {
                    Thread.Sleep(1500);
                    Console.SetCursorPosition(5, 11);
                    Console.WriteLine("System: Kľúč máš v ruke");
                }

                Thread.Sleep(1500);
                Console.SetCursorPosition(5, 12);
                Console.WriteLine("System: Začni povoľovať sviečku");
                char inputplugrelease = char.ToLower(Console.ReadKey(true).KeyChar);
                if (inputplugrelease == 'o')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 13);
                    Console.WriteLine("System: Uvoľnil si a vybral si sviečku");
                }

                Thread.Sleep(1500);
                Console.SetCursorPosition(5, 14);
                Console.WriteLine("System: Daj tam novú sviečku");
                char newplug = char.ToLower(Console.ReadKey(true).KeyChar);
                if (newplug == 'o')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 15);
                    Console.WriteLine("System: Sviečku si vymenil");
                }

                Thread.Sleep(1500);
                Console.SetCursorPosition(5, 16);
                Console.WriteLine("System: Odlož 6-uholníkový kľúč na svoje miesto");
                char postponekey = char.ToLower(Console.ReadKey(true).KeyChar);
                if (postponekey == 'r')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("System: Kľúč si odložil na svoje miesto");
                    player.Inventory.Remove("6-uholníkový kľúč");
                    string path = @"C:\Users\smrzo\Desktop\To-Do List.txt";
                    player.RepairList = File.ReadAllLines(path).ToList();
                    int x2 = 95;
                    int y2 = 2;
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
                }
            }
            ExchangeSparkPlug();

            void ExchangeFuelPipe()
            {
                int x3 = 95;
                int y3 = 2;
                Thread.Sleep(3500);
                Console.Clear();
                Thread.Sleep(1500);
                Console.SetCursorPosition(5, 2);
                Console.WriteLine("System: Teraz ťa čaká výmena palivovej hadičky");

                Thread.Sleep(500);
                for (int i = 0; i < player.RepairList.Count; i++)
                {
                    Console.SetCursorPosition(x3, y3 + i);
                    Console.WriteLine(player.RepairList[i]);
                }

                Thread.Sleep(1500);
                Console.SetCursorPosition(5, 3);
                Console.WriteLine("System: Choď  ku stole po kombinačky");
                char go = char.ToLower(Console.ReadKey(true).KeyChar);
                if (go == 'w')
                {
                    Thread.Sleep(1500);
                    Console.SetCursorPosition(5, 4);
                    Console.WriteLine("System: Si pri stole a zober kombinačky");
                }
                char takepliers = char.ToLower(Console.ReadKey(true).KeyChar);
                if (takepliers == 'r')
                {
                    Thread.Sleep(1500);
                    Console.SetCursorPosition(5, 5);
                    player.Inventory.Add("Kombinačky");
                    Console.WriteLine("System: Kombinačky máš v inventári");
                }

                Thread.Sleep(1500);
                Console.SetCursorPosition(5, 6);
                Console.WriteLine("System: Choď naspäť ku babete");
                char gotobabeta = char.ToLower(Console.ReadKey(true).KeyChar);
                if (gotobabeta == 'w')
                {
                    Thread.Sleep(1500);
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("System: Si pri babete. Otvor inventár, zober kombinačky do ruky a začni vymieňať hadičku");
                }
                char openinv = char.ToLower(Console.ReadKey(true).KeyChar);
                if (openinv == 'e')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("INVENTÁR:");
                    Console.SetCursorPosition(5, 9);
                    player.Inventory.ForEach(Console.Write);
                }

                char takepliersonhand = char.ToLower(Console.ReadKey(true).KeyChar);
                if (takepliersonhand == 'q')
                {
                    Thread.Sleep(1500);
                    Console.SetCursorPosition(5, 10);
                    Console.WriteLine("System: Kombinačky máš v ruke");
                }

                Thread.Sleep(1500);
                Console.SetCursorPosition(5, 11);
                Console.WriteLine("System: Začni vymieňať hadičku");
                char repairingpipe = char.ToLower(Console.ReadKey(true).KeyChar);
                if (repairingpipe == 'o')
                {
                    Thread.Sleep(1500);
                    Console.SetCursorPosition(5, 12);
                    Console.WriteLine("System: Hadičku si vymenil");
                }

                Thread.Sleep(1500);
                Console.SetCursorPosition(5, 13);
                Console.WriteLine("System: Odlož kombinačky na svoje miesto");
                char postponepliers = char.ToLower(Console.ReadKey(true).KeyChar);
                if (postponepliers == 'r')
                {
                    Thread.Sleep(1500);
                    Console.SetCursorPosition(5, 14);
                    Console.WriteLine("System: Kombinačky si vrátil na miesto");
                    player.Inventory.Remove("Kombinačky");
                    for (int i = 0; i < player.RepairList.Count; i++)
                    {
                        Console.SetCursorPosition(x3, y3 + i);
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
                        Console.SetCursorPosition(x3, y3 + i);
                        Console.WriteLine(new string(' ', 50));
                    }

                    for (int i = 0; i < player.RepairList.Count; i++)
                    {
                        Console.SetCursorPosition(x3, y3 + i);
                        Console.WriteLine(player.RepairList[i]);
                    }
                }
                Thread.Sleep(1500);
                Console.SetCursorPosition(5, 17);
                Console.WriteLine("System: Dokončil si základnú údržbu");
            }
            ExchangeFuelPipe();

            void GoSleep()
            {
                Thread.Sleep(3000);
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();

                sleep.GoSleep();

                day2.MorningDay2();
                piston.PistonExchange();
                ring.ExchangepistonRing();
                sealing.ExchangeengineSealing();
                cabling.RepairReplaceCabling();
                bulbs.ExchangelightBulbs();

                Thread.Sleep(3000);
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();

                sleep.GoSleep();

                day3.day3();
                end.end();
               // menu.menu();
            }
        }
    }
}
