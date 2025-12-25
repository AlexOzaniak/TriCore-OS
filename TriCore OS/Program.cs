using System.Diagnostics;
using TriCore_OS.Grafika;
using TriCore_OS.Login;
using TriCore_OS.Spustanie_Programov;

FileEngine engine = new FileEngine();
loginScreenUI ui = new loginScreenUI();
MainGraphics mainGraphics = new MainGraphics();


TextCentering textCentering = new TextCentering();

LoginDetailsExtraction extraction = new LoginDetailsExtraction();
Zobrazenie_Casu cas = new Zobrazenie_Casu();
cas.ShowTime();
Console.ReadKey();


engine.EngineStart(extraction);
