using System;
using System.Linq;

namespace Exam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new int[] { 1, 2, 1, 5, 6, 1, 2, 5 };
            ReadIntergerList(list);

            var input = "[(hi){thisis}test]";
            PrintBalanced(input);

            input = "[(hi){thisis}test";
            PrintBalanced(input);

            Console.ReadKey();
        }

        private static void PrintBalanced(string input)
        {
            if (IsBalanced(input))
                Console.WriteLine($"The string { input } is balanced");
            else
                Console.WriteLine($"The string { input } is not balanced");
        }

        /// <summary>
        /// write a method that validates a string as a balanced or unbalanced string. 
        /// A balanced string is the one that  has a corresponding closing bracket for every open bracket.
        /// Example of a balanced string is: [(hi){thisis}test]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static bool IsBalanced(string input)
        {
            var isbalanced = false;
            var charArray = input.ToCharArray();

            foreach (var item in charArray)
            {
                if (item == '[')
                {
                    if (input.Contains(']'))
                        isbalanced = true;
                    else
                        isbalanced = false; break;
                }

                if (item == '{')
                {
                    if (input.Contains('}'))
                        isbalanced = true;
                    else
                        isbalanced = false; break;
                }

                if (item == '(')
                {
                    if (input.Contains(')'))
                        isbalanced = true;
                    else
                        isbalanced = false; break;
                }
            }

            return isbalanced;
        }

        /// <summary>
        /// Write a method that takes a list of integers as input and prints out the distinct list of integers and number of times each integer is repeated.
        /// </summary>
        /// <param name="list"></param>
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
