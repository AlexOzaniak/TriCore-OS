using TriCore_OS.Grafika;
using TriCore_OS.Login;
using TriCore_OS.Grafika;


Console.WriteLine("TriCore OS");







FileEngine fileengine = new FileEngine();
int maxHeight = Console.LargestWindowHeight;
int maxWith = Console.LargestWindowWidth;
Console.SetBufferSize(maxWith, maxHeight);

Console.WriteLine("TriCore OS - start point");

// iba na vytvorenie tried
FileEngine engine = new FileEngine();
LoginDetailsExtraction login = new LoginDetailsExtraction();     
loginScreenUI ui = new loginScreenUI();             //treba dat login UI (ALEXKO)!!!!!!!!
logoSchreen logo = new logoSchreen();

engine.EngineStart(login);
logo.StartUI();

Console.WriteLine("Pre pokracovanie stlac enter");
Console.ReadKey();
Console.Clear();
