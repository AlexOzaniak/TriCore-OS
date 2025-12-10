
using TriCore_OS;
using TriCore_OS.Grafika;


Console.WriteLine("TriCore OS");

//FileEngine fileengine = new FileEngine();
//fileengine.EngineStart();

//logoSchreen logo = new logoSchreen();
//logo.StartUI();
int maxHeight = Console.LargestWindowHeight;
int maxWith = Console.LargestWindowWidth;

Console.SetBufferSize(maxWith, maxHeight);

Console.WriteLine("Pre pokracovanie stlac enter");
Console.ReadLine();
Console.Clear();

logoSchreen logo = new logoSchreen();

logo.StartUI();
Console.ReadKey();

