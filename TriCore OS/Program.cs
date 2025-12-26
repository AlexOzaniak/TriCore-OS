using TriCore_OS;
using TriCore_OS.Grafika;
using TriCore_OS.Login;
using TriCore_OS.Spustanie_Programov;

FileEngine engine = new FileEngine();
loginScreenUI ui = new loginScreenUI();
MainGraphics mainGraphics = new MainGraphics();
Main_Engine mainEngine = new Main_Engine(); 

TextCentering textCentering = new TextCentering();
logoScreen ui2 = new logoScreen();
LoginDetailsExtraction extraction = new LoginDetailsExtraction();
Zobrazenie_Casu cas = new Zobrazenie_Casu();
cas.ShowTime();
Console.ReadKey();



