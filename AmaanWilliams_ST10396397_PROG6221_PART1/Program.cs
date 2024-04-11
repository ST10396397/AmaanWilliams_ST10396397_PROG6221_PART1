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
            //This is the display for the menu options
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Recipe Application");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1. Enter recipe details");
            Console.WriteLine("2. Display recipe");
            Console.WriteLine("3. Scale recipe");
            Console.WriteLine("4. Reset quantities");
            Console.WriteLine("5. Clear recipe");
            Console.WriteLine("6. Exit");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Enter your choice: ");
            Console.WriteLine("-----------------------------------------");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                //Case 1 is to capture the recipe
                case 1:
                    recipe.EnterRecipeDetails();
                    break;

                //case 2 is to display the captured recipe
                case 2:
                    recipe.DisplayRecipe();
                    break;

                //case 3 is to convert the recipe to differnt measurements
                case 3:
                    Console.Write("Enter scaling factor (0.5, 2, or 3) ");
                    double factor = double.Parse(Console.ReadLine());
                    recipe .ScaleRecipe(factor);
                    recipe .DisplayRecipe();
                    break;

                //case 4 is to reset the rcipe to the orginal value
                case 4:
                    recipe .ResetQuantities();
                    recipe .DisplayRecipe();
                    break;

                //case 5 is to clear the recipe form the system
                case 5:
                    recipe .ClearRecipe();
                    break;

                //case 6 is to exit the application
                case 6:
                    exit = true;
                    break;

                //this is for usres that input a number that is not part of the menu
                default:
                    Console.WriteLine("Invalid chose. Please choose a number between 1 and 6");
                    break;



            }
        }
    }
}





