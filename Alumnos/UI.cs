using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Alumnos.enums;

namespace Alumnos
{
    class UI
    {

        public static void Menu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine(" (1) Add a student in ." + Environment.GetEnvironmentVariable(ConfigurationManager.AppSettings["TextFormat"].ToString(), EnvironmentVariableTarget.User) + " format");
            Console.WriteLine(" (2) Configuration.");
            Console.WriteLine(" (3) Exit.");
        }

        public static void ConfMenu()
        {
            string configformat = ConfigurationManager.AppSettings["TextFormat"];
            var exit = true;

            do
            {
                Console.WriteLine("Choose the text format for new students.");
                Console.WriteLine(" (1) .txt");
                Console.WriteLine(" (2) .json");

                exit = Enum.TryParse<Config>(Console.ReadLine(), out Config ChoosenConfig);

                switch (ChoosenConfig)
                {
                    case Config.txt:
                        Environment.SetEnvironmentVariable(configformat, "txt", EnvironmentVariableTarget.User);                       
                        break;
                    case Config.json:
                        Environment.SetEnvironmentVariable(configformat, "json", EnvironmentVariableTarget.User);                        
                        break;
                    default:
                        Environment.SetEnvironmentVariable(configformat, "txt", EnvironmentVariableTarget.User);                        
                        break;
                }
            } while (!exit);
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

            Console.WriteLine(al.ToString());
            return al;
        }
    }
}
    