using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Alumnos
{
    public class FormatTxt : IFormat
    {
        public void AddToFile(Alumno al)
        {
            //string path = @"C:\Users\enric.pedros\Desktop\alumnes.txt";
            string path = ConfigurationManager.AppSettings["ConfigPath"].ToString() + "alumnes.txt";
            //string stringtoappend = al.Nombre + "," + al.Id + "," + al.Edad + "," + al.Dni + "," + al.Al_Guid;
            try
            {
                // File.AppendAllText(path, toappend); + Environment.NewLine

                if (File.Exists(path))
                {
                    using (StreamWriter strw = File.AppendText(path))
                    {
                        strw.WriteLine(al.ToString());
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
