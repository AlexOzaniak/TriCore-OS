using TriCore_OS.Grafika;
using TriCore_OS.Login;
using TriCore_OS.Grafika;

Console.WriteLine("TriCore OS");

FileEngine fileengine = new FileEngine();
fileengine.EngineStart();

Console.WriteLine("TriCore OS - start point");
FileEngine engine = new FileEngine();
LoginDetailsExtraction login = new LoginDetailsExtraction();
loginScreenUI ui = new loginScreenUI();
ui.ui
engine.EngineStart(login);

