using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Math
    {
        public static int Exec(int num) { return num + 20; }

        public static decimal Exec(decimal num) { return num * 20; }

        public static int Exec(string num)
        {
            int intNum = Convert.ToInt32(num);
            int Num = intNum * 7;
            return Num;
           
        }
    }
}
