using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    class FormatJson : IFormat
    {
        public void AddToFile(Alumno al)
        {
            //string path = @"C:\Users\enric.pedros\Desktop\alumnes.json";
            string path = ConfigurationManager.AppSettings["ConfigPathJson"].ToString();
            //File.WriteAllText(@"c:\movie.json", JsonConvert.SerializeObject(al));           

            TextWriter writer;
            using (writer = new StreamWriter(path, append: true))
            {
                writer.WriteLine(al.ToJson());
            }

            /*
            // serialize JSON directly to a file
            using (StreamWriter strw = File.CreateText(path))
            {
                //JsonSerializer serializer = new JsonSerializer();
                //serializer.Serialize(strw, al);
                strw.WriteLine(al.ToJson());
            }
            */

        }
    }
}
