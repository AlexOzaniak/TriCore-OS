using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.BabetaMaster
{
    public class Engine
    {
        public Player player;    
        private MusicPlayer music;
        
        public void Welcome()
        {
            Console.WriteLine("Stlač hociakú klávesu.");
            Console.ReadLine();
            Console.Clear();
            music = new MusicPlayer();
            music.Play("WelcomeSong.wav");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Thread.Sleep(1000);

            Console.SetCursorPosition(55, 2);
            Console.WriteLine("Ahoj, vítaj v hre BabetaMaster");
            Thread.Sleep(500);
            Console.SetCursorPosition(55, 4);
            Console.WriteLine("Táto hra je simuláciou života v obci s názvom Skalité.");
            Console.SetCursorPosition(55, 5);
            Thread.Sleep(500);
            Console.WriteLine("Budeš hrať za postavu menom David, ktorý sa snaží opraviť svoju babetu.");
            Console.SetCursorPosition(55, 6);
            Thread.Sleep(500);
            Console.WriteLine("Čaká na teba zoznam oprav, ktoré budeš musieť urobiť.");
            Console.SetCursorPosition(55, 7);
            Thread.Sleep(500);
            Console.WriteLine("Taktiež budeš prechádzať rôznymi výzvami a veľa ďalším.");
            Thread.Sleep(500);
            Console.SetCursorPosition(55, 9);
            Console.WriteLine("Odporúčam ti pozrieť si Nastavenia");
            Thread.Sleep(500);
            Console.SetCursorPosition(55, 11);
            Console.WriteLine("Ak si pripravený stlač ENTER.");
            Console.ReadLine();
        }
        public void Settings()
        {
            while (true)
            {
                Console.Clear();
                System.Threading.Thread.Sleep(500);
                Console.SetCursorPosition(65, 18);
                Console.WriteLine("Základné ovládanie hry:");
                System.Threading.Thread.Sleep(500);
                Console.SetCursorPosition(65, 20);
                Console.WriteLine("Pokračovať: ENTER");
                System.Threading.Thread.Sleep(500);
                Console.SetCursorPosition(65, 21);
                Console.WriteLine("Voziť sa na babete: W");
                System.Threading.Thread.Sleep(500);
                Console.SetCursorPosition(65, 22);
                Console.WriteLine("Opravovať babetu: O");
                System.Threading.Thread.Sleep(500);
                Console.SetCursorPosition(65, 23);
                Console.WriteLine("Brať veci: R");
                System.Threading.Thread.Sleep(500);
                Console.SetCursorPosition(65, 24);
                Console.WriteLine("Otvárať tašku: E");
                Thread.Sleep(500);
                Console.SetCursorPosition(65, 25);
                Console.WriteLine("Otvárať list oprav: L");
                Thread.Sleep(500);
                Console.SetCursorPosition(65, 26);
                Console.WriteLine("Vrátiť do menu z Nastavení: ESC");
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Escape)
                {
                    return;
                }
            }
        }
        public void Menu()
        {
            while (true)
            {
                music = new MusicPlayer();
                music.Play("MenuSong.wav");
                Console.Clear();
                Thread.Sleep(500);
                Console.SetCursorPosition(70, 18);
                Console.WriteLine("1. HRAŤ");
                Thread.Sleep(500);
                Console.SetCursorPosition(70, 21);
                Console.WriteLine("2. NASTAVENIA");
                Thread.Sleep(500);
                Console.SetCursorPosition(70, 24);
                Console.WriteLine("3. KONIEC");
                ;
                char input = char.ToLower(Console.ReadKey(true).KeyChar);
                switch (input)
                {
                    case '1':
                        Loading();
                        music.Stop();
                        PlayGame();
                        break;
                    case '2':
                        Settings();
                        break;
                    case '3':
                        music.Stop();
                        Environment.Exit(0);
                        break;
                }
            }
        }


        public void Loading()
        {

            Console.Clear();
            Thread.Sleep(1000);
            Thread.Sleep(200);
            Console.SetCursorPosition(70, 20);
            Console.Write("Loading");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(300);
                Console.SetCursorPosition(79 + i, 20);
                Console.Write(".");

            }
        }
        public void PlayGame()
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
                Console.WriteLine("Ty: Čau, tata");
                Console.SetCursorPosition(5, 11);
                Thread.Sleep(1500);
                Console.WriteLine("Otec: Nazdar, už si mal byť zobudený pred hodinou. lebo mi ideš pomáhať s drevom");
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
                Console.WriteLine("Otec: Zober motorovku ja zoberem sekeru a bendzín");
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

                string path = @"C:\Users\Lenovo\Desktop\To-Do List.txt";
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
                    string path = @"C:\Users\Lenovo\Desktop\To-Do List.txt";
                    player.RepairList = File.ReadAllLines(path).ToList();
                    int x2 = 95;
                    int y2 = 2;
                    for (int i = 0; i < player.RepairList.Count; i++)
                    {
                        Console.SetCursorPosition(x2,y2 + i);
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

                Thread.Sleep(1500);
                Console.SetCursorPosition(5, 2);
                Console.WriteLine("Čas: 20:00");
                Thread.Sleep(1500);
                Console.SetCursorPosition(5, 3);
                Console.WriteLine("System: Si unavený. Budeš pokračovať na ďalší deň");
                Thread.Sleep(1500);
                Console.SetCursorPosition(5, 4);
                Console.WriteLine("System: Choď ku posteli");
                char gohomesleep = char.ToLower(Console.ReadKey(true).KeyChar);
                if (gohomesleep == 'w')
                {
                    Thread.Sleep(1500);
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("System: Si pri posteli. Choď spať");
                }
                char gosleep = char.ToLower(Console.ReadKey(true).KeyChar);
                if (gosleep == 'f')
                {
                    Console.Clear();
                    Thread.Sleep(1500);                   
                    Console.SetCursorPosition(70, 20);
                    Console.Write("Spíš");
                    for (int i = 0; i < 10; i++)
                    {
                        Thread.Sleep(300);
                        Console.SetCursorPosition(79 + i, 20);
                        Console.Write(".");
                    }
                }
                 
            }
            GoSleep();


            void Day2()
            {
                Console.Clear();
                Console.SetCursorPosition(5, 2);
                Console.WriteLine("Čas: 10:00 ");
                Console.SetCursorPosition(5, 10);
                Thread.Sleep(1500);
                Console.WriteLine("Otec: David stávaj");
                Console.SetCursorPosition(5, 11);
                Thread.Sleep(1500);
                Console.WriteLine("Ty: Hmmmmmmmmmm");
                Console.SetCursorPosition(5, 12);
                Thread.Sleep(1500);
                Console.WriteLine("Otec: Furt len spíš a nič nerobíš stávaj už");
                Console.SetCursorPosition(5, 13);
                Thread.Sleep(1500);
                Console.WriteLine("Ty: Veď dobre furt");
                Console.SetCursorPosition(5, 10);
                Thread.Sleep(3500);

                Console.Clear();
                Console.SetCursorPosition(5, 2);
                Console.WriteLine("Čas: 10:30");
                Console.SetCursorPosition(5, 3);
                Thread.Sleep(1500);
                Console.WriteLine("System: Ideš sa naraňajkovať");

                Console.SetCursorPosition(5, 10);
                Thread.Sleep(1500);
                Console.WriteLine("Ty: Dobre ráno");
                Console.SetCursorPosition(5, 11);
                Thread.Sleep(1500);
                Console.WriteLine("Mama: Ja ti dám ráno. Najedz sa a choď kosiť záhradu");
                Console.SetCursorPosition(5, 12);
                Thread.Sleep(1500);
                Console.WriteLine("Ty: To zas mám ísť niečo robiť. Už ma to nebaví");
                Console.SetCursorPosition(5, 13);
                Thread.Sleep(1500);
                Console.WriteLine("Otec: Ty čo si drzý. Najedz sa a pakuj kosiť");
                Console.SetCursorPosition(5, 14);
                Thread.Sleep(3500);

                Console.Clear();
                Console.SetCursorPosition(5, 2);
                Console.WriteLine("Čas: 11:00");
                Console.SetCursorPosition(5, 3);
                Thread.Sleep(1500);
                Console.WriteLine("System: Ideš po kosačku do garáže");
                Console.SetCursorPosition(5, 4);
                Thread.Sleep(1500);
                Console.WriteLine("System: Kosačku si vybral a dolial si benzín.");
                Console.SetCursorPosition(5, 5);
                Thread.Sleep(1500);
                Console.WriteLine("System: Ideš kosiť");
                music.Play("Kosacka.wav");
                Console.SetCursorPosition(5, 6);
                Thread.Sleep(9000);
                Console.Clear();
                Console.SetCursorPosition(5, 2);
                Console.WriteLine("Čas: 12:00");
                Console.SetCursorPosition(5, 3);
                Thread.Sleep(1500);
                Console.WriteLine("System: Dokosil si a ideš sa naobedovať");
                Thread.Sleep(3000);

                Console.Clear();
                Console.SetCursorPosition(5, 2);
                Console.WriteLine("Čas: 13:00");
                Console.SetCursorPosition(5, 3);
                Thread.Sleep(1500);
                Console.WriteLine("System: Naobedoval si sa a ideš do garáže");
                Thread.Sleep(3000);
            }
            Day2();

            void ExchangePiston()
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();

                Console.SetCursorPosition(5, 2);
                Console.WriteLine("System: Pokračuj podľa zoznamu ako včera");
                int x4 = 95;
                int y4 = 2;
                Thread.Sleep(500);
                foreach (string line in player.RepairList)
                {
                    Console.SetCursorPosition(x4, y4);
                    Console.WriteLine(line);
                    y4++;
                }
                Console.SetCursorPosition(5, 3);
                Thread.Sleep(1500);
                Console.WriteLine("System: Čaká ťa výmena piestu");
                Console.SetCursorPosition(5, 4);
                Thread.Sleep(1500);
                Console.WriteLine("System: Vyber starý piest");
                char putoutpiston = char.ToLower(Console.ReadKey(true).KeyChar);
                if (putoutpiston == 'o')
                {
                    Console.SetCursorPosition(5, 5);
                    Thread.Sleep(4500);
                    Console.WriteLine("System: Vytiahol si starý piest");
                }

                Console.SetCursorPosition(5, 6);
                Thread.Sleep(1500);
                Console.WriteLine("System: Choď ku stole po nový");
                char gototable = char.ToLower(Console.ReadKey(true).KeyChar);
                if (gototable == 'w')
                {
                    Console.SetCursorPosition(5, 7);
                    Thread.Sleep(1500);
                    Console.WriteLine("System: Si pri stole, zober piest");
                }
                char putpistonininv = char.ToLower(Console.ReadKey(true).KeyChar);
                if (putpistonininv == 'r')
                {
                    player.Inventory.Add("Piest");
                    Console.SetCursorPosition(5, 8);
                    Thread.Sleep(1500);
                    Console.WriteLine("System: Piest máš v inventári");
                }
                Console.SetCursorPosition(5, 9);
                Thread.Sleep(1500);
                Console.WriteLine("System: Choď naspäť ku babete");
                char gotobabeta = char.ToLower(Console.ReadKey(true).KeyChar);
                if (gotobabeta == 'w')
                {
                    Console.SetCursorPosition(5, 10);
                    Thread.Sleep(1500);
                    Console.WriteLine("System: Si pri babete a môžeš tam dávať nový piest");
                }

                char openinv = char.ToLower(Console.ReadKey(true).KeyChar);
                if (openinv == 'e')
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(5, 11);
                    Console.WriteLine("INVENTÁR:");
                    Console.SetCursorPosition(5, 12);
                    player.Inventory.ForEach(Console.Write);
                }

                char putpistoninhand = char.ToLower(Console.ReadKey(true).KeyChar);
                if (putpistoninhand == 'q')
                {
                    Thread.Sleep(1500);
                    Console.SetCursorPosition(5, 13);
                    Console.WriteLine("System: Piest máš v ruke možeš ho tam dať");
                }

                char putpistoninbabeta = char.ToLower(Console.ReadKey(true).KeyChar);
                if (putpistoninbabeta == 'o')
                {
                    Thread.Sleep(4000);
                    Console.SetCursorPosition(5, 14);
                    Console.WriteLine("System: Piest si tam úspešne vložil");
                }
                
                Thread.Sleep(1500);
                Console.SetCursorPosition(5, 15);
                Console.WriteLine("System: Odlož náradie,ktoré si použil");
                int x5 = 95;
                int y5 = 2;
                char puttoolsback = char.ToLower(Console.ReadKey(true).KeyChar);
                if (puttoolsback == 'r')
                {
                    for (int i = 0; i < player.RepairList.Count; i++)
                    {
                        Console.SetCursorPosition(x5, y5 + i);
                        Console.WriteLine(player.RepairList[i]);
                    }

                    if (player.RepairList.Count >= 3)
                    {
                        player.RepairList.RemoveAt(2);
                    }

                    for (int i = 0; i < 20; i++)
                    {
                        Console.SetCursorPosition(x5, y5 + i);
                        Console.Write(new string(' ', 50));
                    }

                    for (int i = 0; i < player.RepairList.Count; i++)
                    {
                        Console.SetCursorPosition(x5, y5 + i);
                        Console.WriteLine(player.RepairList[i]);
                    }

                    Thread.Sleep(1500);
                    Console.SetCursorPosition(5, 16);
                    Console.WriteLine("System: Náradie si odložil");
                }
                
            }
            ExchangePiston();


            
            Console.ReadLine();
        }
    }
}




