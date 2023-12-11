using Practice.cs;
using System;
using System.Text;

namespace Practice.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            builder.Append('-', 10)
            .AppendLine()
            .AppendLine("My Program")
            .Append('-', 10)
            .AppendLine()
            .Replace('-', '+')
            .Remove(0, 10)
            .Insert(0, new string('*', 10));

            Console.WriteLine(builder);
        }

    }
}
