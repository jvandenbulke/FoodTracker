using System;
using System.Collections.Generic;

namespace FoodTracker
{
    public class DayList<T> : List<MealList<Food>>
    {
        public DayList()
        {
        }

        public DayList(int capacity) : base(capacity)
        {
        }

        public DayList(IEnumerable<MealList<Food>> collection) : base(collection)
        {
        }
        
        public int DayCalories
        {
            get
            {
                int sum = 0;
                foreach (var Meal in this)
                {
                    sum += Meal.MealCalories;
                }

                return sum;

            }
        }

        public int DayCarbs
        {
            get
            {
                int sum = 0;
                foreach (var Meal in this)
                {
                    sum += Meal.MealCarbs;
                }

                return sum;

            }
        }

        public int DayProteins
        {
            get
            {
                int sum = 0;
                foreach (var Meal in this)
                {
                    sum += Meal.MealProteins;
                }

                return sum;

            }
        }

        public int DaySugars
        {
            get
            {
                int sum = 0;
                foreach (var Meal in this)
                {
                    sum += Meal.MealSugars;
                }

                return sum;

            }
        }

        public int DayFats
        {
            get
            {
                int sum = 0;
                foreach (var Meal in this)
                {
                    sum += Meal.MealFats;
                }

                return sum;

            }
        }

        public void ViewCalories()
        {
            Console.WriteLine("======================");
            Console.WriteLine("Today's total calories: {0:N}\n", DayCalories);
        }

        public void ViewCarbs()
        {
            Console.WriteLine("======================");
            Console.WriteLine("Today's total carbs: {0:N}\n", DayCarbs);
        }

        public void ViewProteins()
        {
            Console.WriteLine("======================");
            Console.WriteLine("Today's total proteins: {0:N}\n", DayProteins);
        }

        public void ViewSugars()
        {
            Console.WriteLine("======================");
            Console.WriteLine("Today's total sugars: {0:N}\n", DaySugars);
        }

        public void ViewFats()
        {
            Console.WriteLine("======================");
            Console.WriteLine("Today's total fats: {0:N}\n", DayFats);
        }

        public void ViewStats()
        {
            Console.WriteLine("======================");
            Console.WriteLine("Today's total calories: {0:N}", DayCalories);
            Console.WriteLine("Today's total carbs: {0:N}", DayCarbs);
            Console.WriteLine("Today's total proteins: {0:N}", DayProteins);
            Console.WriteLine("Today's total sugars: {0:N}", DaySugars);
            Console.WriteLine("Today's total fats: {0:N}\n", DayFats);
        }


    }

    //    //Read up on this
    //    protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
    //    {
    //        base.OnCollectionChanged(e);
    //    }

}
