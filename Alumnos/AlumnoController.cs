using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    class AlumnoController
    {
        public void AddStudent(Alumno al, string format)
        {
            GlobalFactory Fact = new FormatFactory();
            Fact.CreateFormat(format).AddToFile(al);
        }

    }
}
