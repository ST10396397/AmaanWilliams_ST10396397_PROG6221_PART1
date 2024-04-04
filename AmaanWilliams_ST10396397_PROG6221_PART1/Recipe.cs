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
            
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Enter number of ingredients ");
            int ingredientCount = int.Parse(Console.ReadLine());

            ingredients = new string[ingredientCount];
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Enter details for each ingredient: ");
            Console.WriteLine("-----------------------------------------");
            for (int i = 0; i < ingredientCount; i++)
            {
                Console.WriteLine($"Ingredient {i + 1} - Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Quantity: ");
                string quantity = Console.ReadLine();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Unit of measurement: ");
                string unit = Console.ReadLine();

                ingredients[i] = $"{quantity} {unit} of {name}";
            }

            Console.WriteLine("Enter the number of steps: ");
            Console.WriteLine("-----------------------------------------");
            int stepCount = int.Parse(Console.ReadLine());

            steps = new string[stepCount];
            Console.WriteLine("Enter details for each step: ");
            Console.WriteLine("-----------------------------------------");
            for (int i = 0; i < stepCount; i++)
            {
                Console.Write($"Step {i + 1}: ");
                Console.WriteLine("-----------------------------------------");
                steps[i] = Console.ReadLine();
            }
        }

        public void DisplayRecipe()
        {
            Console.WriteLine("\nRecipe: ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Ingredients: ");
            Console.WriteLine("Steps ");
            Console.WriteLine("-----------------------------------------");
            foreach (var ingredient in ingredients)
            foreach (var step in steps)

            {
                Console.WriteLine($"- {ingredient}");
                Console.WriteLine($"- {step}");
            }
        }

        public void ScaleRecipe(double factor)
        {

        }

        public void ResetQuantities()
        {

        }

        public void ClearRecipe()
        {

        }

        

    }
}
