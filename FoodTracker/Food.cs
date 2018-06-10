using System;
using System.Collections.Generic;

namespace FoodTracker
{
    public class Food
    {
        public Food(string Name)
        {
            this.Name = Name;
        }

        //Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public int Carbs { get; set; }
        public int Proteins { get; set; }
        public int Sugars { get; set; }
        public int Fats { get; set; }

        public void EnterStats()
        {
            
            bool isValid = true;

            do
            {
                isValid = true;

                Console.Write("Enter in the amount of calories: ");
                string x = Console.ReadLine();

                if (int.TryParse(x, out int value))
                {
                    this.Calories = value;
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid Entry.  Please enter a number.\n");
                    isValid = false;

                }

            } while (!isValid);

            isValid = true;
            do
            {
                isValid = true;

                Console.Write("Enter in the amount of carbs: ");
                string x = Console.ReadLine();

                if (int.TryParse(x, out int value))
                {
                    this.Carbs = value;
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid Entry.  Please enter a number.\n");
                    isValid = false;
                }

            } while (!isValid);

            isValid = true;
            do
            {
                isValid = true;

                Console.Write("Enter in the amount of proteins: ");
                string x = Console.ReadLine();

                if (int.TryParse(x, out int value))
                {
                    this.Proteins = value;
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid Entry.  Please enter a number.\n");
                    isValid = false;
                }

            } while (!isValid);

            isValid = true;
            do
            {
                isValid = true;

                Console.Write("Enter in the amount of sugars: ");
                string x = Console.ReadLine();

                if (int.TryParse(x, out int value))
                {
                    this.Sugars = value;
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid Entry.  Please enter a number.\n");
                    isValid = false;
                }

            } while (!isValid);

            isValid = true;
            do
            {
                isValid = true;

                Console.Write("Enter in the amount of fats: ");
                string x = Console.ReadLine();

                if (int.TryParse(x, out int value))
                {
                    this.Fats = value;
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid Entry.  Please enter a number.\n");
                    isValid = false;
                }

            } while (!isValid);
        }

    }

    
}
