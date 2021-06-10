using System.Collections.Generic;

namespace MacroTracker
{
    public class MealFoodMap
    {
        public MealFoodMap()
        {
            Foods = new Dictionary<Food, double>();
        }

        public void AddFood(Food food, double servings)
        {
            Foods.Add(food, servings);
        }

        public void RemoveFood(Food food)
        {
            foreach (Food foodInList in Foods.Keys)
            {
                if (food.Name == foodInList.Name)
                {
                    Foods.Remove(foodInList);
                    break;
                }
            }
        }

        public void EditServing(Food food, double servings)
        {
            RemoveFood(food);
            AddFood(food, servings);
        }

        public override string ToString()
        {
            return "MealFoodMap [Foods=" + Foods.ToString() + "]";
        }

        public Dictionary<Food, double> Foods { get; }
    }
}
