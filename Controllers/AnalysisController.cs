using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HealthFitness.Controllers;

public class AnalysisController: Controller
{
    public IActionResult AnalysisHome()
    {
        return View();
    }
        public IActionResult AnalyzeData()
    {
        var dietData = new List<double> { 10, 12, 11, 13, 12, 11, 25 }; 
        var exerciseData = new List<double> { 5, 7, 6, 8, 5, 7, 6 };

    ViewBag.DietData = dietData;
    ViewBag.ExerciseData = exerciseData;
        return View();
    }
    public IActionResult Recommendations()
    {
        return View();
    }
}
