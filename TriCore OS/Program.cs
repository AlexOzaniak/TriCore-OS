using TriCore_OS;
using TriCore_OS.Grafika;
Main_Engine engine = new Main_Engine();
engine.Engine();

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
cas.ShowTime();
Console.ReadKey();


engine.EngineStart(extraction);
