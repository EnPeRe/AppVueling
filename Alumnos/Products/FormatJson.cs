using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
            string path = @"C:\Users\enric.pedros\Desktop\alumnes.json";
            //File.WriteAllText(@"c:\movie.json", JsonConvert.SerializeObject(al));

            // serialize JSON directly to a file
            using (StreamWriter file = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, al);
            }
        }
    }
}
