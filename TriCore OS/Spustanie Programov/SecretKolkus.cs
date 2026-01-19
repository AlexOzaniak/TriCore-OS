using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.Spustanie_Programov
{
    internal class SecretKolkus
    {
        public void Main()
        {
            AppCommandList appCommandList1 = new AppCommandList();
            Console.Clear();
            Console.WriteLine("Btw toto je gpt ironicke ze");
            Console.Title = "Príbeh o Matejovi Kolkusovi.exe";

            WriteLineColor("Bol raz jeden Matej Kolkus.", ConsoleColor.Cyan);
            WriteLineColor("Na pohľad obyčajný študent IT.", ConsoleColor.Green);
            WriteLineColor("Ale tvrdil o sebe, že je ELITNÝ programátor.", ConsoleColor.Yellow);

            Pause();

            WriteLineColor("Keď niekto povedal: \"Vieš spraviť login systém?\"", ConsoleColor.White);
            WriteLineColor("Matej bez zaváhania odpovedal:", ConsoleColor.DarkCyan);
            WriteLineColor("\"Jasné, to je basic.\"", ConsoleColor.Magenta);

            Pause();

            WriteLineColor("Otvoril Visual Studio.", ConsoleColor.Blue);
            WriteLineColor("Napísal komentár:", ConsoleColor.DarkGray);
            WriteLineColor("// TODO: dopísať neskôr", ConsoleColor.Gray);

            Pause();

            WriteLineColor("A potom sa stalo niečo zvláštne...", ConsoleColor.Red);
            WriteLineColor("Alt + Tab.", ConsoleColor.DarkYellow);
            WriteLineColor("ChatGPT otvorený.", ConsoleColor.Green);

            Pause();

            WriteLineColor("Ctrl + C.", ConsoleColor.DarkGreen);
            WriteLineColor("Ctrl + V.", ConsoleColor.DarkGreen);

            Pause();

            WriteLineColor("Matej sa usmial a povedal:", ConsoleColor.Magenta);
            WriteLineColor("\"Easy, napísal som to za 5 minút.\"", ConsoleColor.Yellow);

            Pause();

            WriteLineColor("Spolužiaci obdivne pozerali.", ConsoleColor.Cyan);
            WriteLineColor("Učiteľ prikývol.", ConsoleColor.DarkBlue);
            WriteLineColor("GPT v pozadí potichu plakal.", ConsoleColor.DarkRed);

            Pause();

            WriteLineColor("Legenda hovorí,", ConsoleColor.White);
            WriteLineColor("že keď sa Mateja opýtaš, ako to funguje...", ConsoleColor.Gray);
            WriteLineColor("odpovie:", ConsoleColor.DarkMagenta);
            WriteLineColor("\"To je dosť komplexné, vysvetlím inokedy.\"", ConsoleColor.Red);

            Pause();

            WriteLineColor("=== BLÍŽI SA KONIEC PRÍBEHU ===", ConsoleColor.DarkYellow);

            Loading("Načítavam ďalšiu kapitolu");

            Console.Clear();
            WriteLineColor("Chapter 2: Matej vs Git Conflict", ConsoleColor.Red);
            WriteLineColor("Coming soon...", ConsoleColor.DarkGray);

            Console.ResetColor();
            Console.WriteLine("\nStlač ľubovoľnú klávesu...");
            Console.ReadKey();

            Console.Clear();
            appCommandList1.ShowCommands();
        }

        static void WriteLineColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Thread.Sleep(900);
        }

        static void Pause()
        {
            Thread.Sleep(1200);
            Console.WriteLine();
        }

        static void Loading(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(text);

            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(600);
                Console.Write(".");
            }

            Thread.Sleep(800);
            Console.WriteLine("\n");
           
         
        }
        
    }

}

