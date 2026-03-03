using Microsoft.AspNetCore.Mvc;

namespace HealthFitness.Controllers;

public class DietController: Controller
{
    public IActionResult DietHome()
    {
        return View();
    }

    public IActionResult FoodLibrary(){
        return View();
    }

    public IActionResult Tracker(){return View()}
}
