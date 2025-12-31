using TriCore_OS;
using TriCore_OS.Grafika;
using TriCore_OS.Login;
using TriCore_OS.Spustanie_Programov;


FileEngine engine = new FileEngine();
loginScreenUI ui = new loginScreenUI();
MainGraphics mainGraphics = new MainGraphics();



TextCentering textCentering = new TextCentering();
logoScreen ui2 = new logoScreen();
LoginDetailsExtraction extraction = new LoginDetailsExtraction();
Zobrazenie_Casu cas = new Zobrazenie_Casu();
StartingProgram program = new StartingProgram();
Login_Engine login_Engine = new Login_Engine();
FileLogin login = new FileLogin();


/*
for (int  i = 0; i < 1; i++)
{
    program.StartProgram();
    
    Console.ReadKey();
}
*/


login_Engine.StartLoginProcess(engine,login);
