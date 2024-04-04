// See https://aka.ms/new-console-template for more information

using AmaanWilliams_ST10396397_PROG6221_PART1;
using Microsoft.Win32.SafeHandles;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

        Recipe recipe = new Recipe();
        bool exit = false;

        while (!exit)
        {

            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Enter recipe details");
            Console.WriteLine("2. Display recipe");
            Console.WriteLine("3. Scale recipe");
            Console.WriteLine("4. Reset quantities");
            Console.WriteLine("5. Clear recipe");
            Console.WriteLine("6. Exit");

            Console.WriteLine("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Recipe EnterRecipeDetails();
                    break;
                case 2:
                    Recipe DisplayRecipe();
                    break;
                case 3:
                    Recipe ScaleRecipe(factor);
                    Recipe DisplayRecipe();
                    break;
                case 4:
                    Recipe ResetQuantities();
                    Recipe DispalyRecipe();
                    break;
                case 5:
                    Recipe ClearRecipe();
                    break;
                case 6:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid chose. Please choose a number between 1 and 6");
                    break;



            }
        }
    }
}





