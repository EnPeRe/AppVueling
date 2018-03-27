using Alumnos.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Alumnos
{
    class Program
    {

        static void Main(string[] args)
        {
            Options ChoosenMenu;
            var continuar = true;
            var AlController = new AlumnoController();
            string configformat = ConfigurationManager.AppSettings["TextFormat"].ToString();
            var env_var_value = Environment.GetEnvironmentVariable(configformat, EnvironmentVariableTarget.User);

            do
            {
                UI.Menu();
                Enum.TryParse<Options>(Console.ReadLine(), out ChoosenMenu);

                switch (ChoosenMenu)
                {
                    case Options.NuevoAlumno:
                        AlController.AddStudent(UI.NewStudent(), env_var_value);
                        break;
                    case Options.Configuracion:
                        UI.ConfMenu();
                        break;
                    case Options.Salir:
                        continuar = false;
                        break;
                    default:
                        break;
                }

            } while (continuar);
        }
    }
}
