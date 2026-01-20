using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.BabetaMaster
{
    public class ToDoList
    {
       public  Player player;
        public void ReadToDoList()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string toDoFile = Path.Combine(folder, "To-Do List.txt");
            player.RepairList = File.ReadAllLines(toDoFile).ToList();
        }
    }
}
