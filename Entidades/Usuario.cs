using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public override string ToString()
        {
            return Username + ";" + Password;
        }
    }
}
