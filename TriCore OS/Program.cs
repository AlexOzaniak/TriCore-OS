using TriCore_OS.Grafika;
using TriCore_OS.Login;
using TriCore_OS.Grafika;


Console.WriteLine("TriCore OS");





FileEngine fileengine = new FileEngine();
LoginDetailsExtraction extraction = new LoginDetailsExtraction();   

Console.WriteLine("TriCore OS - start point");
FileEngine engine = new FileEngine();
LoginDetailsExtraction login = new LoginDetailsExtraction();
loginScreenUI ui = new loginScreenUI();



/*logoSchreen logo = new logoSchreen();
logo.StartUI();
int maxHeight = Console.LargestWindowHeight;
int maxWith = Console.LargestWindowWidth;
Console.SetBufferSize(maxWith, maxHeight);


Console.WriteLine("Pre pokracovanie stlac enter");
Console.ReadLine();
Console.Clear();

engine.EngineStart(login);

engine.EngineStart(login);
logo.StartUI();

Console.WriteLine("Pre pokracovanie stlac enter");
Console.ReadKey();
Console.Clear();
*/



fileengine.EngineStart(extraction);

