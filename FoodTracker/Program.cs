using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTracker
{
    class Program
    {
        static void Main(string[] args)
        {


            //Define Meals
            MealList<Food> breakfast = new MealList<Food>();
            MealList<Food> lunch = new MealList<Food>();
            MealList<Food> dinner = new MealList<Food>();
            MealList<Food> snack = new MealList<Food>();

            // Define List of all items in the list of foods
            DayList<MealList<Food>> todaysMeals = new DayList<MealList<Food>>();
            todaysMeals.Add(breakfast);
            todaysMeals.Add(lunch);
            todaysMeals.Add(dinner);
            todaysMeals.Add(snack);


            //Do while to ask if user wants to enter meal
            bool isValid = true;
            bool enterFood = true;
            string mealName = null;

            do
            {
                Console.Write("Do you want to enter a new food? (Multiple foods can be entered per meal) Y/N ");
                string strName = Console.ReadLine();

                isValid = true;
                enterFood = true;

                if (strName == "y" || strName == "Y")
                {
                    isValid = true;
                    //Do while and switch to have user enter the meal
                    do
                    {
                        Console.Write("\nWhat meal will you be entering? (1 = breakfast, 2 = lunch, 3 = dinner, 4 = snack): ");
                        string str = Console.ReadLine();
                        isValid = true;
                        switch (str)
                        {
                            case "1":
                                mealName = "breakfast";
                                break;
                            case "2":
                                mealName = "lunch";
                                break;
                            case "3":
                                mealName = "dinner";
                                break;
                            case "4":
                                mealName = "snack";
                                break;
                            default:
                                Console.WriteLine("Inavlid entry.  Please try again.");
                                isValid = false;
                                break;

                        }
                    } while (!isValid);

                    isValid = true;

                    //Enter in the food you had for that meal
                    Console.Write("Enter in the food you had for {0}: ", mealName);
                    string fname = Console.ReadLine();
                    Food food = new Food(fname);


                    //Add breakfast to meal list and calculate and display calories
                    food.EnterStats();
                    if (mealName == "breakfast")
                    {
                        breakfast.Add(food);
                        breakfast.ViewStats();
                        todaysMeals.ViewStats();
                    }
                    else if (mealName == "lunch")
                    {
                        lunch.Add(food);
                        lunch.ViewStats();
                        todaysMeals.ViewStats();
                    }

                    else if (mealName == "dinner")
                    {
                        dinner.Add(food);
                        dinner.ViewStats();
                        todaysMeals.ViewStats();
                    }

                    else if (mealName == "snack")
                    {
                        snack.Add(food);
                        snack.ViewStats();
                        todaysMeals.ViewStats();
                    }
                    isValid = true;

                    enterFood = true;
                }

                else if (strName == "N" || strName == "n")
                {
                    Console.WriteLine("No more entries...Click Enter to Close Application...");
                    Console.ReadLine();
                    Environment.Exit(0);
                    enterFood = false; ;
                }
                else
                {
                    Console.WriteLine("Invalid Entry.");
                    enterFood = true;
                }
            } while (enterFood);
        }


    }

}
