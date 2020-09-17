using System;
using System.Text;


namespace Strings
{
    class Program
    {
        static void Main()
        {
            string fName = "Angel";
            string mName = "Justin";
            string lName = "Padilla";
            string fullName = fName + " " + mName + " " + lName;

            Console.WriteLine(fullName);
            Console.WriteLine(fullName.ToUpper());
            Console.ReadLine();

            StringBuilder myparagraph = new StringBuilder();

            bool RunThis = true;
            int num = 1;

            while (RunThis)
            {
                myparagraph.Append("This is sentence " + num + ". ");
                num++;
                Console.WriteLine(myparagraph);
                Console.ReadLine();
                RunThis = myparagraph.Length <= 50;
            }
        }
    }
}
