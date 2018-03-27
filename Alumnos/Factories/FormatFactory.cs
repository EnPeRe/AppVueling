using Alumnos.enums;
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
            Config Typ = (Config)Enum.Parse(typeof(Config), type);

            switch (Typ)
            {
                case Config.txt: return new FormatTxt();
                case Config.json: return new FormatJson();
                default: throw new ArgumentException("Invalid type", "type");
            }
        }
    }
}
