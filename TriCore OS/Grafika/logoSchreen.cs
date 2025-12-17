namespace TriCore_OS.Grafika
{
    internal class logoSchreen
    {
        private int positionX = 55;
        private int positionX2 = 35;
        private int positionY = 25;
        private string logo = nameof(LoadingUI);

        public void StartUI()
        {
            Console.CursorVisible = false;
            LoadingUI();

        }

        private void LogoUI()
        {
            string[] lines = new string[]
            {
"████████████████████████████████████████████████████████████████████████████████████████████████████████",
"█                                                                                                      █",
"█                  ████████╗██████╗ ██╗    ██████╗ ██████╗ ██████╗ ███████╗                            █",
"█                  ╚══██╔══╝██╔══██╗██║   ██╔════╝██╔═══██╗██╔══██╗██╔════╝                            █",
"█                     ██║   ██████╔╝██║   ██║     ██║   ██║██████╔╝█████╗                              █",
"█                     ██║   ██╔══██╗██║   ██║     ██║   ██║██╔══██╗██╔══╝                              █",
"█                     ██║   ██║  ██║██║   ╚██████╗╚██████╔╝██║  ██║███████╗                            █",
"█                     ╚═╝   ╚═╝  ╚═╝╚═╝    ╚═════╝ ╚═════╝ ╚═╝  ╚═╝╚══════╝                            █",
"█                                                                                                      █",
"█                                                                                                      █",
"█                         T  R  I  C  O  R  E   O P E R A T I N G   S Y S T E M                        █",
"█                                                                                                      █",
"█                                                                                                      █",
"█                                       Tri Core OS Original                                           █",
"█                                                                                                      █",
"████████████████████████████████████████████████████████████████████████████████████████████████████████"
            };

            int startY = (Console.WindowHeight / 2) - (lines.Length / 2) - 2;
            int widthConsole = Console.WindowWidth;

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                int xStart = (widthConsole / 2) - (line.Length / 2);
                if (xStart < 0) xStart = 0;
                int y = startY + i;
                if (y < 0) y = 0;
                try
                {
                    Console.SetCursorPosition(xStart, y);
                    Console.WriteLine(line);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Error!!");
                }
            }


        }



        private void LoadingUI()
        {
            LogoUI();
            CursorPositionLoadning();
            Thread.Sleep(500);
            Console.Write("[░░░░░░░░░░░░░░░░]   0%  ─⊙─  Starting boot sequence");

            Thread.Sleep(500);
            Console.Clear();

            LogoUI();
            CursorPositionLoadning();
            Console.Write(" [██░░░░░░░░░░░░░░]  10%  ─⊙─  Initializing I/O");

            Thread.Sleep(700);
            Console.Clear();

            LogoUI();
            CursorPositionLoadning();
            Console.Write(" [████░░░░░░░░░░░░]  20%  ─⊙─  Loading core drivers");

            Thread.Sleep(400);
            Console.Clear();

            LogoUI();
            CursorPositionLoadning();
            Console.Write(" [██████░░░░░░░░░░]  30%  ─⊙─  Detecting hardware");

            Thread.Sleep(400);
            Console.Clear();

            LogoUI();
            CursorPositionLoadning();
            Console.Write(" [████████░░░░░░░░]  40%  ─⊙─  Mounting virtual FS");

            Thread.Sleep(400);
            Console.Clear();

            LogoUI();
            CursorPositionLoadning();
            Console.Write(" [██████████░░░░░░]  50%  ─⊙─  Launching services");

            Thread.Sleep(700);
            Console.Clear();

            LogoUI();
            CursorPositionLoadning();
            Console.Write("  [████████████░░░░]  60%  ─⊙─  Network stack online");
            MiniText();
            Thread.Sleep(100);
            Console.Clear();

            LogoUI();
            CursorPositionLoadning();
            Console.Write(" [██████████████░░]  70%  ─⊙─  Security modules ready");

            Thread.Sleep(300);
            Console.Clear();

            LogoUI();
            CursorPositionLoadning();
            Console.Write(" [████████████████]  80%  ─⊙─  Optimizing system");

            Thread.Sleep(300);
            Console.Clear();

            LogoUI();
            CursorPositionLoadning();
            Console.Write(" [██████████████████░░]  90% ─⊙─  Preparing UI");

            Thread.Sleep(800);
            Console.Clear();

            LogoUI();
            CursorPositionLoadning();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" [████████████████████] 100% ─⊙─  TriCore ready!");
            Console.ForegroundColor = ConsoleColor.White;

            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;

        }

        private void CursorPositionLoadning()
        {

            int centerX = Console.WindowWidth / 2;
            int centerY = Console.WindowHeight / 2;
            int y = centerY + 10;
            int x = Math.Max(0, centerX - 30);
            Console.SetCursorPosition(x, y);
        }

    }
}
