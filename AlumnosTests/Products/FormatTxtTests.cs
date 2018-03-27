using Microsoft.VisualStudio.TestTools.UnitTesting;
using Alumnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Alumnos.Tests
{
    [TestClass()]
    public class FormatTxtTests
    {
        
        [TestMethod()]
        public void AddToFileTest()
        {
            Alumno al_test = new Alumno("H", 1, 1, "1");

            FormatTxt formattxt = new FormatTxt();
            formattxt.AddToFile(al_test);

            string[] readed = this.ReadFromTxt();
            string linefinal = "";
            foreach (string line in readed){
                linefinal = line;
            }
            Assert.IsTrue(al_test.Equals(FromTxtToAl(linefinal)));
            
            throw new NotImplementedException();
        }

        private Alumno FromTxtToAl(string textal)
        {

            Alumno al = null;
            return al;
        }



        public string[] ReadFromTxt()
        {

            string path = @"C:\Users\enric.pedros\Desktop\alumnes.txt";
            string[] linesreaded;
            // File.AppendAllText(path, toappend); + Environment.NewLine
            linesreaded = File.ReadAllLines(path);
            //foreach (string line in linesreaded)
            //{
            //}
            return linesreaded;
        }
    }
}