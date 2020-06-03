using Example06.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example06.Storage
{
    public class FoodStorage
    {
        public ObservableCollection<Food> Foods { get; } = new ObservableCollection<Food>();

        public void AddFood(Food food)
        {
            Foods.Add(food);
        }

        public void AddTestData()
        {
            Foods.Add(new Food { Name = "Æble", Calories = 52, FiberContent = 3});
            Foods.Add(new Food { Name = "Mælk", Calories = 42, FiberContent = 0});
            Foods.Add(new Food { Name = "Æble", Calories = 41, FiberContent = 3 });
        }
    }
}
