using System;

namespace _10012650_task1_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
           //Start the program with Clear();
           Console.Clear();

           //make opening instructions
           //make variables
           //Make caluclation
           //Output to user

           Console.WriteLine("Welcome to the degrees calculator!");
           Console.WriteLine();
           Console.WriteLine("Fahrenheit                 Code: f");
           Console.WriteLine("Celsius                    Code: c");
           Console.WriteLine();
           Console.Write("Enter the code to select Between Fahrenheit and Celsius: ");
           

           var celsius = "c";
           var Fahrenheit = "f";
           var userInput = Console.ReadLine();

           if (userInput == celsius)
           {
               Console.WriteLine("_______________________________________________");
               Console.WriteLine();
               Console.WriteLine("This program will convert Celsius to fahrenheit");
               Console.Write("Enter how many degrees you want to convert: ");
               

               double answer = double.Parse(Console.ReadLine());
               double convertedAnswer = Math.Round(answer * 9 / 5 + 32, 2);

               Console.WriteLine($"Fahrenheit is {convertedAnswer}");
           }
           else if (userInput == Fahrenheit)
           {
               Console.WriteLine("_______________________________________________");
               Console.WriteLine();
               Console.WriteLine("This program will convert Fahrenheit to Celsius");
               Console.WriteLine();
               Console.WriteLine("Enter how many degrees you want to convert: ");

               double answer2 = double.Parse(Console.ReadLine());
               double convertedAnswer2 = Math.Round(answer2 -32 * 5 / 9, 2);

               Console.WriteLine($"Fahrenheit is {convertedAnswer2}");
           }
           else
           {
               Console.WriteLine("You didn't enter the right code!");
           }
           
           //End the program with blank line and instructions
           Console.ResetColor();
           Console.WriteLine();
           Console.WriteLine("Press <Enter> to quit the program");
           Console.ReadKey();

        }
    }
}
