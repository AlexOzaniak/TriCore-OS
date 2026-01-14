using System.Diagnostics;
using TriCore_OS;
using TriCore_OS.Grafika;
using TriCore_OS.Login;

public class FileEngine :FileLogin
{
     FileRegistration registration = new FileRegistration();
    Login_Engine Login_Engine = new Login_Engine();
    LoginDetailsExtraction extraction = new LoginDetailsExtraction();
    loginScreenUI logiUi = new loginScreenUI();

    public void FileStart(FileLogin login )
    {

        Console.CursorVisible = true;
        string roamingFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        FilePath = Path.Combine(roamingFolder, "userlogininfo.txt");
        login.FilePath = this.FilePath;
        registration.FilePath = this.FilePath;

        logiUi.LoginScreenUIDo();
        // Console.WriteLine("type your username");          //only for development
        Login_Engine.CenteringCursor();
        string InputUsername = Console.ReadLine();
        Login_Engine.CenteringCursorPassword();
        // Console.WriteLine("type your password");            //only for development
        string InputPassword = Console.ReadLine();
        Console.WriteLine(InputPassword);
        extraction.ExtractLoginDetails(login);
        PaswordEncrypting encrypting = new PaswordEncrypting();



        if (InputUsername != extraction.SavedUserName)
        {
            //Console.WriteLine("wrong name");                //this is for development
            registration.RegisterDetails(encrypting);
        }
        else if (InputPassword != extraction.SavedPassword)
        {
            //Console.WriteLine("wrong Password");              //this is for development

        }
        else
        {
            Console.Clear();
            Console.WriteLine("Logging In");
        
            
            for ( int i = 0; i < 10; i++ )
            {
                
                Console.Write(">");
                Thread.Sleep(400);
                
            }
            Console.WriteLine();
            
            Console.WriteLine($"{InputUsername.ToUpper()} Welcome Back!");
            Console.WriteLine("Press any Key to continue ");
            Console.ReadKey();
            
            // po tom ako  sa pouzivatel  uspesne prihlasi zobrazit co sa da -- Patrik






        }


       
    }

    
        



    }

