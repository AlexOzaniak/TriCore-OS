using TriCore_OS.Grafika;
using TriCore_OS.Login;

Console.WriteLine("TriCore OS - start point");
FileEngine engine = new FileEngine();
LoginDetailsExtraction login = new LoginDetailsExtraction();
loginScreenUI ui = new loginScreenUI();
ui.ui
engine.EngineStart(login);

