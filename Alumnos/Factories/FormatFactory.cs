using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    class FormatFactory : GlobalFactory
    {
        public override IFormat CreateFormat(string type)
        {
            switch (type)
            {
                case "txt": return new FormatTxt();
                case "json": return new FormatJson();
                default: throw new ArgumentException("Invalid type", "type");
            }
        }
    }
}
