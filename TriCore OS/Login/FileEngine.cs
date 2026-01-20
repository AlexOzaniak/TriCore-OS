using System.Diagnostics;
using TriCore_OS;
using TriCore_OS.Grafika;
using TriCore_OS.Login;
using TriCore_OS.Spustanie_Programov;

public class FileEngine : FileLogin
{
    FileRegistration registration = new FileRegistration();
    LoginDetailsExtraction extraction = new LoginDetailsExtraction();
    loginScreenUI logiUi = new loginScreenUI();
    logoScreen logoUi = new logoScreen();
    AppCommandList appCommandList = new AppCommandList();
    AppsList apps = new AppsList();
    PaswordEncrypting encrypting = new PaswordEncrypting();
 
    StartingProgram startingProgram = new StartingProgram();
    


    public void FileStart(FileLogin login)
    {
        
        Console.CursorVisible = true;

        string roamingFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string triCoreFolder = Path.Combine(roamingFolder, "TriCore OS");

        if (!Directory.Exists(triCoreFolder))
        {
            Directory.CreateDirectory(triCoreFolder);
        }

        FilePath = Path.Combine(triCoreFolder, "userlogininfo.txt");

        login.FilePath = FilePath;
        registration.FilePath = FilePath;



        logiUi.LoginScreenUIDo();
        // Console.WriteLine("type your username");          //only for development
        CenteringCursor();

        string InputUsername = Console.ReadLine();
        CenteringCursorPassword();
        // Console.WriteLine("type your password");            //only for development
        string InputPassword = Console.ReadLine();
        Console.WriteLine(InputPassword);
        extraction.ExtractLoginDetails(login);
      



        if (InputUsername != extraction.SavedUserName)
        {
            //Console.WriteLine("wrong name");                //this is for development
            registration.RegisterDetails(encrypting);
        }
        else if (InputPassword != extraction.SavedPassword)
        {
            //Console.WriteLine("wrong Password"); 
            //this is for development
            registration.RegisterDetails(encrypting);

        }
        else
        {
            Console.Clear();
            Console.WriteLine("Logging In");


            for (int i = 0; i < 10; i++)
            {

                Console.Write(">");
                Thread.Sleep(400);

            }
            Console.WriteLine();

            Console.WriteLine($"{InputUsername.ToUpper()} Welcome Back!");
            Console.WriteLine("Press any Key to continue ");
            Console.ReadKey();
            Console.Clear();

         
            apps.BuildAppsList();
           
            
           // appCommandList.ShowCommands();
        }
    }

            // po tom ako  sa pouzivatel  uspesne prihlasi zobrazit co sa da -- Patrik


    internal void CenteringCursorPassword()
    {
        int centerX = Console.WindowWidth / 2;
        int centerY = Console.WindowHeight / 2;
        int y = centerY + 5;
        int x = Math.Max(0, centerX - 17);
        Console.SetCursorPosition(x, y);
    }
    public void CenteringCursor()
    {
        int centerX = Console.WindowWidth / 2;
        int centerY = Console.WindowHeight / 2;
        int y = centerY + 3;
        int x = Math.Max(0, centerX - 17);
        Console.SetCursorPosition(x, y);
    }



}


