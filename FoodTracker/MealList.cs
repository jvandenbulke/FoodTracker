using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;

namespace FoodTracker
{

    public class MealList<T> : List<Food>
    {
        string MealName;

        public MealList()
        {

        }

        public void Add(string name, int calories)
        {
            var data = new Food(name)
            {
                Name = name,
                Calories = calories
            };     
            this.Add(data);
        }

        public int MealCalories
        {
            get
            {
                int sum = 0;
                foreach (var Food in this)
                {
                    sum += Food.Calories;
                }
                return sum;

            }
        }

        public int MealCarbs
        {
            get
            {
                int sum = 0;
                foreach (var Food in this)
                {
                    sum += Food.Carbs;
                }
                return sum;

            }
        }

        public int MealProteins
        {
            get
            {
                int sum = 0;
                foreach (var Food in this)
                {
                    sum += Food.Proteins;
                }
                return sum;

            }
        }

        public int MealSugars
        {
            get
            {
                int sum = 0;
                foreach (var Food in this)
                {
                    sum += Food.Sugars;
                }
                return sum;

            }
        }

        public int MealFats
        {
            get
            {
                int sum = 0;
                foreach (var Food in this)
                {
                    sum += Food.Fats;
                }
                return sum;

            }
        }

        public void ViewCalories()
        {
            Console.WriteLine("======================");
            Console.WriteLine("This meal's total calories: {0:N}", MealCalories);
        }

        public void ViewCarbs()
        {
            Console.WriteLine("======================");
            Console.WriteLine("This meal's total carbs: {0:N}", MealCarbs);
        }

        public void ViewProteins()
        {
            Console.WriteLine("======================");
            Console.WriteLine("This meal's total proteins: {0:N}", MealProteins);
        }

        public void ViewSugars()
        {
            Console.WriteLine("======================");
            Console.WriteLine("This meal's total sugars: {0:N}", MealSugars);
        }

        public void ViewFats()
        {
            Console.WriteLine("======================");
            Console.WriteLine("This meal's total fats: {0:N}", MealFats);
        }

        public void ViewStats()
        {
            Console.WriteLine("======================");
            Console.WriteLine("This meal's total calories: {0:N}", MealCalories);
            Console.WriteLine("This meal's total carbs: {0:N}", MealCarbs);
            Console.WriteLine("This meal's total proteins: {0:N}", MealProteins);
            Console.WriteLine("This meal's total sugars: {0:N}", MealSugars);
            Console.WriteLine("This meal's total fats: {0:N}", MealFats);
        }
    }

    //    //Read up on this
    //    protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
    //    {
    //        base.OnCollectionChanged(e);
    //    }

}
