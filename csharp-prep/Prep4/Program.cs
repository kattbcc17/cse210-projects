using System;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine(" Enter a list of numbers, type 0 when finished. ");
        int userInput = -1;
        while (userInput != 0)
        {
            Console.WriteLine(" Enter number: ");

            string userAnswer = Console.ReadLine();
            userInput = int.Parse(userAnswer);

            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        }

        int sum = 0;
        foreach (int number in numbers) 
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}. ");

        // Computing the average

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Find the max
        int maxNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                // Find the new max
                maxNumber = number;
            }

            Console.WriteLine($"The largest number is: {maxNumber}. ");
        }

    }
}