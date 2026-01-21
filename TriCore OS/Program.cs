using TriCore_OS.BabetaMaster;
﻿using TriCore_OS;
using TriCore_OS.Grafika;
using TriCore_OS.Login;

logoScreen logoloadingUI  = new logoScreen();
FileEngine loginRegistration = new FileEngine();
FileRegistration registration = new FileRegistration();
AppsMenuContr mainMenu = new AppsMenuContr();
StartGame startGame = new StartGame();









logoloadingUI.StartUI();
loginRegistration.FileStart(registration);
//mainMenu.AppsMenuControl();


