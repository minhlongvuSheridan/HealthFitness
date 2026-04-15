using System.Collections.Generic;

namespace HealthFitness.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string Instructions { get; set; } = "";
        public string Difficulty { get; set; } = "";
        public string BodyPart { get; set; } = "";
        public string Goal { get; set; } = "";
        public string Equipment { get; set; } = "";
        public string Location { get; set; } = "";
        public string TargetMuscle { get; set; } = "";
        public string? ImageUrl { get; set; }
        public string? YouTubeVideoId { get; set; }
        public List<ExerciseImage> Images { get; set; } = new();
    }

    public class ExerciseImage
    {
        public int Id { get; set; }
        public string ImagePath { get; set; } = "";
    }
}