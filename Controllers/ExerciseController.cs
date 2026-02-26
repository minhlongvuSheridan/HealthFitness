using Microsoft.AspNetCore.Mvc;

namespace HealthFitness.Controllers;

public class ExerciseController: Controller
{
    public IActionResult ExerciseHome()
    {
        return View();
    }
}
