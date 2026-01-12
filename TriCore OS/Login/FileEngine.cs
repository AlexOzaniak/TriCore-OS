using System.Diagnostics;
using TriCore_OS;
using TriCore_OS.Login;

public class FileEngine :FileLogin
{
     FileRegistration registration = new FileRegistration();
    Login_Engine Login_Engine = new Login_Engine();
    LoginDetailsExtraction extraction = new LoginDetailsExtraction();
    

    public void FileStart(FileLogin login )
    {

        Console.CursorVisible = true;
        string roamingFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        FilePath = Path.Combine(roamingFolder, "userlogininfo.txt");
        login.FilePath = this.FilePath;
        registration.FilePath = this.FilePath;


        Console.WriteLine("type your username");
        string InputUsername = Console.ReadLine();
        Login_Engine.CenteringCursorPassword();
        Console.WriteLine("type your password");
        string InputPassword = Console.ReadLine();
        Console.WriteLine(InputPassword);
        extraction.ExtractLoginDetails(login);
        PaswordEncrypting encrypting = new PaswordEncrypting();



        if (InputUsername != extraction.SavedUserName)
        {
            //Console.WriteLine("wrong name");                //this is for development
            registration.RegisterDetails();
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
            
            //Console.WriteLine($"{InputUsername.ToUpper()} Welcome Back!");

        }


       
    }

    
        



    }

