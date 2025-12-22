using System.Diagnostics;
using TriCore_OS.Grafika;
using TriCore_OS.Login;

FileEngine engine = new FileEngine();
loginScreenUI ui = new loginScreenUI();
MainGraphics mainGraphics = new MainGraphics();


TextCentering textCentering = new TextCentering();
logoSchreen ui2 = new logoSchreen();
LoginDetailsExtraction extraction = new LoginDetailsExtraction();
Console.ReadKey();

engine.EngineStart(extraction);