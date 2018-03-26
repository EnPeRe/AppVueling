using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    abstract class GlobalFactory
    {
        public abstract IFormat CreateFormat(string type);
    }
}
