using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Id { get; set; }
        public string Dni { get; set; }

        public Alumno()
        {

        }

        public Alumno(string nombre, int edad, int id, string dni)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Id = id;
            this.Dni = dni;
        }

        public override bool Equals(object obj)
        {
            var alumno = obj as Alumno;
            return alumno != null &&
                   Nombre == alumno.Nombre &&
                   Edad == alumno.Edad &&
                   Id == alumno.Id &&
                   Dni == alumno.Dni;
        }

        public override int GetHashCode()
        {
            var hashCode = -1662571869;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nombre);
            hashCode = hashCode * -1521134295 + Edad.GetHashCode();
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + Dni.GetHashCode();
            return hashCode;
        }
    }
}
