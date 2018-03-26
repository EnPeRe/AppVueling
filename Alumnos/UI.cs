using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    class UI
    {

        public static void Menu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine(" (1) Add a student.");
            Console.WriteLine(" (2) Configuration.");
            Console.WriteLine(" (3) Exit.");
        }

        public static void ConfMenu()
        {
            Console.WriteLine("Choose the text format for new students.");
            Console.WriteLine(" (1) .txt");
            Console.WriteLine(" (2) .json"); 
            switch (Console.ReadLine())
            {
                case "1":
                    Environment.SetEnvironmentVariable("TextFormat_minus", "txt", EnvironmentVariableTarget.User);
                    break;
                case "2":
                    Environment.SetEnvironmentVariable("TextFormat_minus", "json", EnvironmentVariableTarget.User);
                    break;
                default:
                    Environment.SetEnvironmentVariable("TextFormat_minus", "txt", EnvironmentVariableTarget.User);
                    break;
            }
        }

        public static Alumno NewStudent()
        {
            Alumno al = null;
            string nom, dni;
            Console.WriteLine("Write the name:");
            nom = Console.ReadLine();
            Console.WriteLine("Write the id:");
            Int32.TryParse(Console.ReadLine(), out int id);
            Console.WriteLine("Write the age:");
            Int32.TryParse(Console.ReadLine(), out int age);
            Console.WriteLine("Write the dni:");
            dni = Console.ReadLine();
            al = new Alumno(nom, age, id, dni);
            return al;
        }
    }
}
    