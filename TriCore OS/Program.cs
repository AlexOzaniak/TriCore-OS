using TriCore_OS.BabetaMaster;
﻿using TriCore_OS;
using TriCore_OS.Grafika;
using TriCore_OS.Login;
using TriCore_OS.Programs;
using TriCore_OS.Spustanie_Programov;
using TriCore_OS.Spustanie_Programov;
FileEngine engine1 = new FileEngine();
Engine enginegame = new Engine();
loginScreenUI ui = new loginScreenUI();
MainGraphics mainGraphics = new MainGraphics();
Main_Engine mainEngine = new Main_Engine();
logoScreen ui2 = new logoScreen();
LoginDetailsExtraction extraction = new LoginDetailsExtraction();
Zobrazenie_Casu cas = new Zobrazenie_Casu();
StartingProgram program = new StartingProgram();
Login_Engine login_Engine = new Login_Engine();
FileLogin login = new FileLogin();
AppCommandList list = new AppCommandList();
MomsFood momsFood = new MomsFood();
Zobrazenie_Casu zobrazenie_Casu = new Zobrazenie_Casu();
Engine babetta = new Engine();




//babetta.Welcome();
//babetta.Menu();
//babetta.PlayGame();

Console.ReadLine();
engine1.FileStart(login);

zobrazenie_Casu.ShowTime();



//login_Engine.StartLoginProcess(engine,login);
//list.ShowCommands();
//momsFood.WriteFoodRecipes();