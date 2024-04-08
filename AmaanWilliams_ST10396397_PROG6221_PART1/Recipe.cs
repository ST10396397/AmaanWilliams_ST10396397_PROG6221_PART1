using System;
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
            Console.WriteLine("Steps ");
            foreach (var ingredient in ingredients)
 
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
            for (int i = 0;i < ingredients.Length; i++)
            {
                String[] parts = ingredients[i].Split(' ');
                double quantity = double.Parse(parts[0]) * factor;
                ingredients[i] = $"{quantity} {parts[1]} of {parts[4]}";

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
