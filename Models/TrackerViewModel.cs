namespace HealthFitness.Models;

public class TrackerViewModel
{
    public List<Food> FoodLibrary { get; set; }
    public List<Food> SelectedFoods { get; set; }
    public int TotalCalories { get; set; }
    public int TotalProtein { get; set; }
    public int TotalCarbs { get; set; }
    public int TotalFat { get; set; }

    public string SelectedFoodName { get; set; }
}
