

internal class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>();
        while (numbers.Count < 5)
        {
            Console.WriteLine("Please enter a number that you have not entered before: ");
            var enteredNumber = Convert.ToInt32(Console.ReadLine());
            if (numbers.Contains(enteredNumber))
            {
                Console.WriteLine("You have already entered " + enteredNumber);
                continue;
            }

            numbers.Add(enteredNumber);
        }

        numbers.Sort();
        Console.WriteLine();
        Console.WriteLine("These are the numbers you entered and I sorted:");

        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}