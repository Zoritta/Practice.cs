using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.cs
{
    public class StringUtility
    {
        public static string SummerizedText(string text, int maxLength = 18)
        {
            if (text.Length < maxLength)
                return text;


            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }

            return String.Join(" ", summaryWords) + "...";
        }
    }
}
