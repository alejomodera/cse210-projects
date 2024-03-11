using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        int numbers = -1;

        List<int> numbersList = new List<int>();

        Console.WriteLine ("Enter a list of numbers, type 0 when finished.");
        do{
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            int numbers1 = int.Parse(input);
            numbers = numbers1;

            if (numbers != 0){
                numbersList.Add (numbers);
            }
            

        }while(numbers != 0);

        int NumberSum = 0;

        foreach (int number in numbersList){
            NumberSum += number;
        } 
        Console.WriteLine($"The sum is {NumberSum}");

        int totalNumbers = numbersList.Count;
        int average = NumberSum / totalNumbers;
        Console.WriteLine($"The average is: {average}");

        int largestNumber = numbersList.Max();

        Console.WriteLine ($"The largest number is: {largestNumber}");

    }
}