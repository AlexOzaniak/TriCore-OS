using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.BabetaMaster
{
    public class Day1
    {      
        private MusicPlayer music;
        public Player player;
        public void Morningday1()
        {           
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();


            Console.SetCursorPosition(5, 2);
            Console.WriteLine("Čas: 7:00 ");
            Console.SetCursorPosition(5, 10);
            Thread.Sleep(2500);
            Console.WriteLine("Mama: David stávaj!");
            Console.SetCursorPosition(5, 11);
            Thread.Sleep(2500);
            Console.WriteLine("Ty: ........");
            Console.SetCursorPosition(5, 12);
            Thread.Sleep(2500);
            Console.WriteLine("Mama: Nepočul si stávaj!");
            Console.SetCursorPosition(5, 13);
            Thread.Sleep(2500);
            Console.WriteLine("Ty: Veď už idem");
            Thread.Sleep(3000);

            Console.Clear();
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("Čas: 7:30 ");
            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("System: Vstal si a ideš sa naraňajkovať");
            Thread.Sleep(3500);
            Console.SetCursorPosition(5, 10);
            Thread.Sleep(2500);
            Console.WriteLine("Ty: Čau tata");
            Console.SetCursorPosition(5, 11);
            Thread.Sleep(2500);
            Console.WriteLine("Otec: Nazdar, už si mal byť zobudený pred hodinou. Ideš pomáhať s drevom");
            Console.SetCursorPosition(5, 12);
            Thread.Sleep(2500);
            Console.WriteLine("Ty: To zas ? Šak minule sme rezali drevo.");
            Console.SetCursorPosition(5, 13);
            Thread.Sleep(2500);
            Console.WriteLine("Otec: Jak zas. Ide zima tak treba mať s čím kúriť.");
            Console.SetCursorPosition(5, 14);
            Thread.Sleep(2500);
            Console.WriteLine("Otec: Tak sa naraňajkuj a pôjdeme.");
            Console.SetCursorPosition(5, 15);
            Thread.Sleep(2500);
            Console.WriteLine("Ty: No okej");
            Thread.Sleep(3500);

            Console.Clear();
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("Čas: 8:00 ");
            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("System: Naraňajkoval si sa a ideš s otcom rezať drevo.");

            Console.SetCursorPosition(5, 10);
            Thread.Sleep(2500);
            Console.WriteLine("Otec: Zober motorovku ja zoberem sekeru a benzín");
            Console.SetCursorPosition(5, 11);
            Thread.Sleep(2500);
            Console.WriteLine("Ty: No ja už idem ku drevu");
            Console.SetCursorPosition(5, 12);
            Thread.Sleep(2500);
            Console.WriteLine("Otec: Dobre počkaj ma tam");
            Console.SetCursorPosition(5, 13);
            Thread.Sleep(2500);
            Console.WriteLine("Ty: Kde je ten otec toľko. Nebudem tu tak dlho čakať");
            Console.SetCursorPosition(5, 14);
            Thread.Sleep(3000);
            Console.WriteLine("Ty: No konečne si tu.");
            Console.SetCursorPosition(5, 15);
            Thread.Sleep(2500);
            Console.WriteLine("Otec: Daj mi tu pílu a ideme to rezať");
            music = new MusicPlayer();
            music.Play("Motorovka.wav");

            Thread.Sleep(13000);
            Console.Clear();
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("Čas: 12:00");
            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("System: Dorezali ste drevo");
            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("System: Idete sa naobedovať");
            Thread.Sleep(3000);

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Clear();
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("Čas: 13:00");
            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("System: Naobedoval si sa");
            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("System: Ideš do garáže opravovať babetu");
            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("System: Na stole je zoznam oprav, ktoré musíš urobiť");
            Thread.Sleep(2500);
            Console.SetCursorPosition(5, 6);
            Console.WriteLine("System: Otvor zoznam");

            int x = 5;
            int y = 9;

           
                char input = char.ToLower(Console.ReadKey(true).KeyChar);
                
                
                    foreach (string line in player.RepairList)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine(line);
                        y++;
                    }
        }
    }
}
            
        


