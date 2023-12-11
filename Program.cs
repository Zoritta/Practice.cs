using System;

class Program
{
    static void Main(string[] args)
    {
        var sentence = "This is going to be a really really really long text.";
        var summary = SummerizedText(sentence);
        Console.WriteLine(summary);

    }

    static string SummerizedText(string text, int maxLength = 18)
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