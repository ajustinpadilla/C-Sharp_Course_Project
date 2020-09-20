using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarConstuctors
{
    public class Secretkey
    {
        public Secretkey(string name) : this(name, "blue") { }
        public Secretkey(string name, string color)
        {
            Name = name;
            Color = color;
        }
        public string Name { get; set; }
        public string Color { get; set; }
    }
}
