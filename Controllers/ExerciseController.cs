using Microsoft.AspNetCore.Mvc;

namespace HealthFitness.Controllers;

public class ExerciseController: Controller
{
    public IActionResult ExerciseHome()
    {
        return View();
    }

    public IActionResult AnalyzeData()
    {
        return View();
    }
    public IActionResult Recommendations()
    {
        return View();
    }
}
