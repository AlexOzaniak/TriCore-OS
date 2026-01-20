using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.BabetaMaster
{
    public class Day2
    {
        public MusicPlayer music; 
        public void MorningDay2()
        {
            Console.Clear();
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("Čas: 10:00 ");
            Console.SetCursorPosition(5, 10);
            Thread.Sleep(2500);
            Console.WriteLine("Otec: David stávaj");
            Console.SetCursorPosition(5, 11);
            Thread.Sleep(2500);
            Console.WriteLine("Ty: Hmmmmmmmmmm");
            Console.SetCursorPosition(5, 12);
            Thread.Sleep(2500);
            Console.WriteLine("Otec: Furt len spíš a nič nerobíš stávaj už");
            Console.SetCursorPosition(5, 13);
            Thread.Sleep(2500);
            Console.WriteLine("Ty: Veď dobre furt");
            Console.SetCursorPosition(5, 10);
            Thread.Sleep(3500);

            Console.Clear();
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("Čas: 10:30");
            Console.SetCursorPosition(5, 3);
            Thread.Sleep(2500);
            Console.WriteLine("System: Ideš sa naraňajkovať");

            Console.SetCursorPosition(5, 10);
            Thread.Sleep(2500);
            Console.WriteLine("Ty: Dobre ráno");
            Console.SetCursorPosition(5, 11);
            Thread.Sleep(2500);
            Console.WriteLine("Mama: Ja ti dám ráno. Najedz sa a choď kosiť záhradu");
            Console.SetCursorPosition(5, 12);
            Thread.Sleep(2500);
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
            Thread.Sleep(2500);
            Console.WriteLine("System: Ideš po kosačku do garáže");
            Console.SetCursorPosition(5, 4);
            Thread.Sleep(2500);
            Console.WriteLine("System: Kosačku si vybral a dolial si benzín.");
            Console.SetCursorPosition(5, 5);
            Thread.Sleep(2500);
            Console.WriteLine("System: Ideš kosiť");
            music = new MusicPlayer();
            music.Play("Kosacka.wav");
            Console.SetCursorPosition(5, 6);
            Thread.Sleep(9000);
            Console.Clear();
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("Čas: 12:00");
            Console.SetCursorPosition(5, 3);
            Thread.Sleep(2500);
            Console.WriteLine("System: Dokosil si a ideš sa naobedovať");
            Thread.Sleep(3000);

            Console.Clear();
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("Čas: 13:00");
            Console.SetCursorPosition(5, 3);
            Thread.Sleep(2500);
            Console.WriteLine("System: Naobedoval si sa a ideš do garáže");
            Thread.Sleep(3000);
        }
    }
}
