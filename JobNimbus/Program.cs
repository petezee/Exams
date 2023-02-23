using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNimbus
{
    class Program
    {
        static void Main(string[] args)
        {
            string param = "";
            Console.Write("Enter string:");
            param = Console.ReadLine();

            var result = checkBracket(param);

            Console.Write($"Result is: {result}");

            Console.ReadLine();
        }

        public static bool checkBracket(string param)
        {
            //PSZ: HONEST Goggled
            //  *best way to iterate in string
            int isBalanced = 0;
            foreach (char c in param)
            {
                if (c == '{')
                    isBalanced++;
                if (c == '}')
                    isBalanced--;

                if (isBalanced < 0)
                    break;

            }
            return isBalanced == 0;
        }
    }
}
