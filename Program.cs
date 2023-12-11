using Practice.cs;
using System;

namespace Practice.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really long text.";
            var summary = StringUtility.SummerizedText(sentence);
            Console.WriteLine(summary);

        }

    }
}
