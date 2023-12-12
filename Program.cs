using Practice.cs;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Practice.cs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var input = Console.ReadLine();
            var checkResult = CheckConsecutive(input);
            Console.WriteLine(checkResult);


        }
        public static string CheckConsecutive(string input)
        {
            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            var isConsecutive = true;
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            return message;
        }

    }

}
