using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new int[] { 1, 2, 1 };
            //ReadIntergerList(list);

            string input = "[(hi){thisis}test]";

            if (IsBalanceString(input))
                Console.WriteLine($"The string { input } is balanced");
            else
                Console.WriteLine($"The string { input } is not balanced");

            input = "[(hi){thisis}test";
            if (IsBalanceString(input))
                Console.WriteLine($"The string { input } is balanced");
            else
                Console.WriteLine($"The string { input } is not balanced");


            Console.ReadKey();
        }

        private static bool IsBalanceString(string param)
        {
            var isbalance = false;
            var array = param.ToCharArray();

            foreach (var item in array)
            {
                if (item == '[')
                {
                    if (param.Contains(']'))
                        isbalance = true;
                    else
                        isbalance = false; break;
                }

                if (item == '{')
                {
                    if (param.Contains('}'))
                        isbalance = true;
                    else
                        isbalance = false; break;
                }

                if (item == '(')
                {
                    if (param.Contains(')'))
                        isbalance = true;
                    else
                        isbalance = false; break;
                }
            }

            return isbalance;
        }

        private static void ReadIntergerList(int[] list)
        {
            var distincts = list.Distinct().ToList();
            foreach (var item in distincts)
            {
                Console.WriteLine($"item: {item} repeated: { list.Where(c => c.Equals(item)).Count() }");
            }

        }


    }
}
