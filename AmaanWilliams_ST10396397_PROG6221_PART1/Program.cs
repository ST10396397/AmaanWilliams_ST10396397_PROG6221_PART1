// See https://aka.ms/new-console-template for more information

using AmaanWilliams_ST10396397_PROG6221_PART1;
using Microsoft.Win32.SafeHandles;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nOptions:");
        Console.WriteLine("1. Enter recipe details");
        Console.WriteLine("2. Display recipe");
        Console.WriteLine("3. Scale recipe");
        Console.WriteLine("4. Reset quantities");
        Console.WriteLine("5. Clear recipe");
        Console.WriteLine("6. Exit");

        Console.WriteLine("Enter your choice: ");
        int choice = ReadChoice();

        if(Choice == 1)
        {
            Recipe.EnterRecipeDetails();
        }
        else if (choice == 2)
        {
            Recipe.DisplayRecipe();
        }
        else if (choice == 3)
        {
            Console.Write("Enter scaling (0.5, 2 or 3) ");
            double factor = ReadSclaingFactor();
            Recipe.ScaleRecipe(factor);
            Recipe.DisplayRecipe();
        }
        else if(choice == 4)
        {
            Recipe.ResetQuantites();
            Recipe.DisplayRecipe();
        }
        else if (choice == 5)
        {
            Recipe.ClearRecipe();
        }
        else if (choice ==6)
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 6");
        }      
    }
}





