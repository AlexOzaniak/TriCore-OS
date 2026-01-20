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

        public void PlayGame()
        {
            ExchangeSparkPlug plug = new ExchangeSparkPlug();
            Menu menu = new Menu();
            StartGame startGame = new StartGame();
            Player player = new Player();
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

            day1.player = player;
            sealing.player = player;
            pipe.player = player;
            bulbs.player = player;
            piston.player = player;
            ring.player = player;
            plug.player = player;
            cabling.player = player;
            list.player = player;

            startGame.GameStart();

            bool startGameFromMenu = menu.menu();

            if (startGameFromMenu)
            {
                day1.Morningday1();
                list.ReadToDoList();
                plug.ExchangePlug();
                pipe.ExchangefuelPipe();

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
                menu.menu();
            }
        }
    }
}


