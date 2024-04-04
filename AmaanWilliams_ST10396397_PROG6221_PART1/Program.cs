﻿// See https://aka.ms/new-console-template for more information

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

           
            Console.WriteLine("Recipe storage");
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
                case 1:
                    recipe.EnterRecipeDetails();
                    break;
                case 2:
                    recipe.DisplayRecipe();
                    break;
                case 3:
                    Console.Write("Enter scaling factor (0.5, 2, or 3) ");
                    Console.WriteLine("-----------------------------------------");
                    double factor = double.Parse(Console.ReadLine());
                    recipe .ScaleRecipe(factor);
                    recipe .DisplayRecipe();
                    break;
                case 4:
                    recipe .ResetQuantities();
                    recipe .DisplayRecipe();
                    break;
                case 5:
                    recipe .ClearRecipe();
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





