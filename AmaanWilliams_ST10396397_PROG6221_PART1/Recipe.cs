﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaanWilliams_ST10396397_PROG6221_PART1
{
    using System;
    class Recipe
    {
        private string[] ingredients;
        private string[] steps;
        private double[] originalQuantities; 


        public void EnterRecipeDetails()
        {  
            Console.WriteLine("Enter number of ingredients ");
            int ingredientCount = int.Parse(Console.ReadLine());
            ingredients = new string[ingredientCount];           
            Console.WriteLine("Enter details for each ingredient: ");          
            for (int i = 0; i < ingredientCount; i++)

            {
                Console.WriteLine($"Ingredient {i + 1} - Name: ");
                string name = Console.ReadLine();           
                Console.WriteLine($"Quantity: ");
                string quantity = Console.ReadLine();
                Console.WriteLine($"Unit of measurement: ");
                string unit = Console.ReadLine();
                ingredients[i] = $"{quantity} {unit} of {name}";
            }

            Console.WriteLine("Enter the number of steps: ");
            int stepCount = int.Parse(Console.ReadLine());

            steps = new string[stepCount];
            Console.WriteLine("Enter details for each step: ");
            for (int i = 0; i < stepCount; i++)
            {
                Console.Write($"Step {i + 1}: ");
                steps[i] = Console.ReadLine();
            }
        }

        public void DisplayRecipe()
        {
            Console.WriteLine("\nRecipe: ");
            Console.WriteLine("Ingredients: ");
            foreach (string ingredient in ingredients)
 
            {
                Console.WriteLine($"- {ingredient}");
            }
            Console.WriteLine("\nSteps");
            for(int i = 0;i < steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");
            }
        }

        public void ScaleRecipe(double factor)
        {
            for (int i = 0; i < ingredients.Length; i++)
            {
                string[] parts = ingredients[i].Split(' ');
                double originalQuantity = double.Parse(parts[0]);
                string unit = parts[1];
                string name = string.Join(" ", parts, 3, parts.Length - 3); // Joining the name parts together
                double scaledQuantity;

                // Calculate scaled quantity based on the factor
                if (factor == 0.5)
                {
                    scaledQuantity = originalQuantity * 0.5;
                }
                else if (factor == 2)
                {
                    scaledQuantity = originalQuantity * 2;
                }
                else if (factor == 3)
                {
                    scaledQuantity = originalQuantity * 3;
                }
                else
                {
                    Console.WriteLine("Invalid scaling factor.");
                    return;
                }

                // Update the ingredient with the scaled quantity
                ingredients[i] = $"{scaledQuantity} {unit} of {name}";
            }
        }

        public void ResetQuantities()
        {
            
        }

        public void ClearRecipe()
        {
            ingredients = null;
            steps = null;
        }


    }
}
