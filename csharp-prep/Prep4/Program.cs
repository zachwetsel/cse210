using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumber = 1;

        while (newNumber != 0)
        {
            Console.WriteLine("Enter a number (Enter 0 to quit).");
            newNumber = int.Parse(Console.ReadLine());

            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            } 
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of your list is {sum}. ");

       float average = ((float)sum) / numbers.Count;
       Console.WriteLine($"The average of your list is {average}. ");

        int biggest = 0;
       foreach (int number in numbers)
       {
            if (number > biggest)
            {
                biggest = number;
            }
       }
       Console.WriteLine($"The biggest number on your list is {biggest}. ");

    }
}