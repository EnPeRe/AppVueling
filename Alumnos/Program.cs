using Alumnos.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    class Program
    {

        static void Main(string[] args)
        {
            Options ChoosenMenu;
            var continuar = true;
            var AlController = new AlumnoController();

            do
            {
                UI.Menu();
                Enum.TryParse<Options>(Console.ReadLine(), out ChoosenMenu);

                switch (ChoosenMenu)
                {
                    case Options.NuevoAlumno:
                        AlController.AddStudent(UI.NewStudent(), Environment.GetEnvironmentVariable("TextFormat_minus", EnvironmentVariableTarget.User));
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
