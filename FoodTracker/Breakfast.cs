using System.Collections.Generic;

namespace FoodTracker
{
    public class Breakfast<T> : List<Food>
    {
        public Breakfast(IEnumerable<Food> collection) : base(collection)
        {
        }

        public int Sum(List<Food> meal)
        {
            int ret = 0;
            foreach (var Food in this)
            {
                ret += Food.Calories;
            }
            return ret;
        }
    }

    //    //Read up on this
    //    protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
    //    {
    //        base.OnCollectionChanged(e);
    //    }

}
