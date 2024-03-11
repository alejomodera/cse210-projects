using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?: ");
        string input = Console.ReadLine();
        int gradePercentage = int.Parse(input);

        string gradeletter = "";

        if (gradePercentage >= 90)
        {
            gradeletter = "A";
            //Console.WriteLine($"Your grade score is: {gradeletter}");
        }
        else if (gradePercentage >= 80)
        {   
            gradeletter = "B";
            //Console.WriteLine("$Your grade score is: {gradeletter}");
        }
        else if (gradePercentage >= 70)
        {
            gradeletter = "C";
            //Console.WriteLine($"Your grade score is: {gradeletter}");
        }
        else if (gradePercentage >= 60)
        {
            gradeletter = "D";
            //Console.WriteLine($"Your grade score is: {gradeletter}");
        }
        else if (gradePercentage < 60)
        {
            gradeletter = "F";
            //Console.WriteLine($"Your grade score is: {gradeletter}");
        }

        Console.WriteLine($"Your grade score is: {gradeletter}");

        if (gradePercentage >= 70)
        {   
            Console.WriteLine("Congratulations! You have passed the class");
        }

        else
        {
            Console.WriteLine("You have failed the class. You can do better next time!");
        }
    }
}