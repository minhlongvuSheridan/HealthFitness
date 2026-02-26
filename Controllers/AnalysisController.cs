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
        return View();
    }
    public IActionResult Recommendations()
    {
        return View();
    }
}
