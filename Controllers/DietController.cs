using Microsoft.AspNetCore.Mvc;
using HealthFitness.Models;
using System.Text.Json;

namespace HealthFitness.Controllers;

public class DietController: Controller
{
    public IActionResult DietHome()
    {
        return View();
    }

    public IActionResult FoodLibrary(){
        var foods = new List<Food>
        {
            new Food { name = "Apple", calories = 95, protein = 0,carbs=15, fat=0 },
            new Food { name = "Chicken Breast", calories = 165, protein = 25,carbs=1,fat=3 },
            new Food { name = "Rice", calories = 206, protein = 0,carbs=15, fat=0 },
            new Food { name = "Broccoli", calories = 55, protein = 3, carbs=15, fat=0 }
        };

        return View(foods);
    }

    private List<Food> GetFoodLibrary()
    {
        return new List<Food>
        {
            new Food { name = "Apple", calories = 95, protein = 0,carbs=15, fat=0 },
            new Food { name = "Chicken Breast", calories = 165, protein = 25,carbs=1,fat=3 },
            new Food { name = "Rice", calories = 206, protein = 0,carbs=15, fat=0 },
            new Food { name = "Broccoli", calories = 55, protein = 3, carbs=15, fat=0 }
        };
    }
    private List<Food> GetTrackerList()
    {
        var sessionData = HttpContext.Session.GetString("Tracker");
        if (sessionData == null)
            return new List<Food>();

        return JsonSerializer.Deserialize<List<Food>>(sessionData);
    }
    public IActionResult Tracker(){
        var selectedFoods = GetTrackerList();

        var vm = new TrackerViewModel
        {
            FoodLibrary = GetFoodLibrary(),
            SelectedFoods = selectedFoods,
            TotalCalories = selectedFoods.Sum(f => f.calories),
            TotalProtein = selectedFoods.Sum(f => f.protein),
            TotalCarbs = selectedFoods.Sum(f => f.carbs),
            TotalFat = selectedFoods.Sum(f => f.fat)
        };

        return View(vm);
        }
        private void SaveTrackerList(List<Food> foods)
    {
        HttpContext.Session.SetString("Tracker", JsonSerializer.Serialize(foods));
    }
    
    [HttpPost]
    public IActionResult AddFood(string selectedFoodName)
    {
        var foods = GetFoodLibrary();
        var tracker = GetTrackerList();

        var selectedFood = foods.FirstOrDefault(f => f.name == selectedFoodName);

        if (selectedFood != null)
        {
            tracker.Add(selectedFood);
            SaveTrackerList(tracker);
        }

        return RedirectToAction("Tracker");
    }
}
