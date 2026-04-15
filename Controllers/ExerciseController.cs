using HealthFitness.Services;
using Microsoft.AspNetCore.Mvc;

namespace HealthFitness.Controllers
{
    public class ExerciseController : Controller
    {
        private readonly ExerciseService _exerciseService;

        public ExerciseController(ExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }

        public IActionResult ExerciseHome()
        {
            return View();
        }

        public IActionResult ExerciseFilter(string? bodyPart, string? goal, string? difficulty, string? equipment)
        {
            var exercises = _exerciseService.FilterExercises(bodyPart, goal, difficulty, equipment);

            ViewBag.SelectedBodyPart = bodyPart;
            ViewBag.SelectedGoal = goal;
            ViewBag.SelectedDifficulty = difficulty;
            ViewBag.SelectedEquipment = equipment;

            return View(exercises);
        }

        public IActionResult ExerciseInfo(int id)
        {
            var exercise = _exerciseService.GetExerciseById(id);

            if (exercise == null)
            {
                return NotFound();
            }

            return View(exercise);
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
}