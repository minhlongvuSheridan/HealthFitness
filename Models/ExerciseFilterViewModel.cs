using System.Collections.Generic;

namespace HealthFitness.Models
{
    public class ExerciseFilterViewModel
    {
        public string? BodyPart { get; set; }
        public string? Goal { get; set; }
        public string? Difficulty { get; set; }
        public string? Equipment { get; set; }
        public List<Exercise> Exercises { get; set; } = new();
    }
}