using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string UserName = PromptUserName();
        int UserNumber = PromptUserNumber();
        int SquaredNumber = SquareNumber(UserNumber);

        DisplayResult(UserName, SquaredNumber);

    }


    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string NameInput = Console.ReadLine();
        return NameInput;
    }
    
    static int PromptUserNumber ()
    {
        Console.Write("Please enter your favorite number: ");
        string Number = Console.ReadLine();
        int NumberInput = int.Parse(Number);
        return NumberInput;
    }
    
    static int SquareNumber (int number)
    {
        int NumberSquared = number * number;
        return NumberSquared;
    }
    static void DisplayResult (string name, int number){
        Console.WriteLine($"{name}, the square of your number is {number}");
    }

}