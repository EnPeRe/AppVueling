using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    class FormatTxt : IFormat
    {
        public void AddToFile(Alumno al)
        {
            string path = @"C:\Users\enric.pedros\Desktop\alumnes.txt";
            string stringtoappend = al.Nombre + "," + al.Id + "," + al.Edad + "," + al.Dni;
            try
            {
                // File.AppendAllText(path, toappend); + Environment.NewLine
                using (StreamWriter str = File.AppendText(path))
                {
                    str.WriteLine(stringtoappend);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
