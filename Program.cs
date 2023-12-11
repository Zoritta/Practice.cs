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
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var reversed = ReverseName(name);
            Console.WriteLine(reversed);
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];
            return new string(array);
        }

    }
}
