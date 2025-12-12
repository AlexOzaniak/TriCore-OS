using TriCore_OS.Grafika;
using TriCore_OS.Login;


Console.WriteLine("TriCore OS");
Console.ReadLine();
Console.Clear();


//FileEngine fileengine = new FileEngine();

//Console.WriteLine("TriCore OS - start point");
//FileEngine engine = new FileEngine();
//LoginDetailsExtraction login = new LoginDetailsExtraction();
//loginScreenUI ui = new loginScreenUI();
//engine.EngineStart(login);

logoSchreen logo = new logoSchreen();
logo.StartUI();
Console.Clear();
TextCentering textCenter = new TextCentering();
loginScreenUI loginUI = new loginScreenUI();

// center the login UI (as multiple lines) in the console
var loginLines = loginUI.BuildLoginScreen();
textCenter.CenterText(loginLines, Console.WindowHeight / 2);



Console.ReadKey();







