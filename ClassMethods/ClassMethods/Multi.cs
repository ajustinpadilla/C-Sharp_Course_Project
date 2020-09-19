using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    public class Multi
    {
        public void Half(int num1, out int num2)
        {
            num2 = num1 / 2;
        }

        public int DubTogether(int num1, int num2) { return (num1 + num2)*2; }
        public decimal DubTogether(decimal num1, decimal num2) { return (num1 + num2) * 2; }
        public static string Concat(string word1, string word2) { return word1 + " " + word2; }
    }
}
