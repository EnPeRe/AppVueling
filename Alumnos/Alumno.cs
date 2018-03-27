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
        public Guid Al_Guid { get; set; }

        public Alumno()
        {
            this.Al_Guid = Guid.NewGuid();
        }

        public Alumno(string nombre, int edad, int id, string dni)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Id = id;
            this.Dni = dni;
            this.Al_Guid = Guid.NewGuid();
        }

        public Alumno(string nombre, int edad, int id, string dni, Guid guid)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Id = id;
            this.Dni = dni;
            this.Al_Guid = guid;
        }

        public override bool Equals(object obj)
        {
            var alumno = obj as Alumno;
            return alumno != null &&
                   Nombre == alumno.Nombre &&
                   Edad == alumno.Edad &&
                   Id == alumno.Id &&
                   Dni == alumno.Dni &&
                   Al_Guid == alumno.Al_Guid;
        }

        public override int GetHashCode()
        {
            var hashCode = 1550485279;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nombre);
            hashCode = hashCode * -1521134295 + Edad.GetHashCode();
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Dni);
            hashCode = hashCode * -1521134295 + EqualityComparer<Guid>.Default.GetHashCode(Al_Guid);
            return hashCode;
        }

        public override string ToString()
        {
            //return base.ToString();
            return this.Nombre + "," + this.Id + "," + this.Edad + "," + this.Dni + "," + this.Al_Guid;
        }

        public string ToJson()
        {
            //return base.ToString();
            return "{\"Nombre\":\"" + this.Nombre + "\",\"Id\":" + this.Id + ",\"Edad\":" + this.Edad +
                ",\"Dni\":\"" + this.Dni + "\",\"Guid\":" + this.Al_Guid + "}";
        }
    }
}
