using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalMethodParameters
{
    public class Math
    {
        public int Add(int num1, int num2 = 5) { return num1 + num2; }
    }
}
