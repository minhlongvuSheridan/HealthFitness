using HealthFitness.Models;

namespace HealthFitness.Services
{
    public class ExerciseService
    {
        private readonly List<Exercise> _exercises = new()
        {
            new Exercise
            {
                Id = 1,
                Name = "Bench Press",
                Description = "A classic chest exercise for building upper body pushing strength.",
                Instructions = "Lie flat on a bench, grip the bar slightly wider than shoulder-width, lower it to your chest, then press it back up under control.",
                Difficulty = "Intermediate",
                BodyPart = "Chest",
                Goal = "Strength",
                Equipment = "Barbell",
                Location = "Gym",
                TargetMuscle = "Pectorals",
                ImageUrl = "/images/exercises/benchpress.jpg",
                YouTubeVideoId = "rT7DgCr-3pg",
                Images = new List<ExerciseImage>
                {
                    new ExerciseImage { Id = 1, ImagePath = "/images/exercises/benchpress.jpg" }
                }
            },
            new Exercise
            {
                Id = 2,
                Name = "Push-Up",
                Description = "A bodyweight chest movement that also works the shoulders and triceps.",
                Instructions = "Start in a plank position, lower your body until your chest is close to the floor, then push back up while keeping your body straight.",
                Difficulty = "Beginner",
                BodyPart = "Chest",
                Goal = "Strength",
                Equipment = "None",
                Location = "Home",
                TargetMuscle = "Chest",
                ImageUrl = "/images/exercises/pushup.jpg",
                YouTubeVideoId = "IODxDxX7oi4",
                Images = new List<ExerciseImage>
                {
                    new ExerciseImage { Id = 1, ImagePath = "/images/exercises/pushup.jpg" }
                }
            },
            new Exercise
            {
                Id = 3,
                Name = "Pull-Up",
                Description = "A powerful back exercise using your own bodyweight.",
                Instructions = "Hang from a pull-up bar with hands slightly wider than shoulders. Pull yourself up until your chin clears the bar, then lower with control.",
                Difficulty = "Intermediate",
                BodyPart = "Back",
                Goal = "Strength",
                Equipment = "Pull-Up Bar",
                Location = "Gym",
                TargetMuscle = "Lats",
                ImageUrl = "/images/exercises/pullup.jpg",
                YouTubeVideoId = "eGo4IYlbE5g",
                Images = new List<ExerciseImage>
                {
                    new ExerciseImage { Id = 1, ImagePath = "/images/exercises/pullup.jpg" }
                }
            },
            new Exercise
            {
                Id = 4,
                Name = "Seated Cable Row",
                Description = "A back exercise that helps build thickness and posture.",
                Instructions = "Sit upright, grab the handle, pull it toward your torso, squeeze your shoulder blades, then return slowly.",
                Difficulty = "Beginner",
                BodyPart = "Back",
                Goal = "Strength",
                Equipment = "Cable Machine",
                Location = "Gym",
                TargetMuscle = "Mid Back",
                ImageUrl = "/images/exercises/cablerow.jpg",
                YouTubeVideoId = "HJSVR_67OlM"
            },
            new Exercise
            {
                Id = 5,
                Name = "Barbell Squat",
                Description = "One of the best lower body exercises for size and strength.",
                Instructions = "Place the bar on your upper back, brace your core, squat down until your thighs are at least parallel, then stand back up.",
                Difficulty = "Intermediate",
                BodyPart = "Legs",
                Goal = "Strength",
                Equipment = "Barbell",
                Location = "Gym",
                TargetMuscle = "Quadriceps",
                ImageUrl = "/images/exercises/squat.jpg",
                YouTubeVideoId = "ultWZbUMPL8"
            },
            new Exercise
            {
                Id = 6,
                Name = "Walking Lunges",
                Description = "A leg exercise that improves balance and unilateral strength.",
                Instructions = "Step forward into a lunge, lower until both knees are bent, then step forward and repeat with the other leg.",
                Difficulty = "Beginner",
                BodyPart = "Legs",
                Goal = "Strength",
                Equipment = "Dumbbell",
                Location = "Gym",
                TargetMuscle = "Quadriceps",
                ImageUrl = "/images/exercises/lunges.jpg",
                YouTubeVideoId = "QOVaHwm-Q6U"
            },
            new Exercise
            {
                Id = 7,
                Name = "Dumbbell Shoulder Press",
                Description = "A shoulder exercise for building pressing strength and size.",
                Instructions = "Hold dumbbells at shoulder level, press them overhead until your arms are extended, then lower back down slowly.",
                Difficulty = "Intermediate",
                BodyPart = "Shoulders",
                Goal = "Strength",
                Equipment = "Dumbbell",
                Location = "Gym",
                TargetMuscle = "Deltoids",
                ImageUrl = "/images/exercises/shoulderpress.jpg",
                YouTubeVideoId = "qEwKCR5JCog"
            },
            new Exercise
            {
                Id = 8,
                Name = "Lateral Raise",
                Description = "An isolation movement for the side delts.",
                Instructions = "Hold a dumbbell in each hand, raise your arms out to the sides until shoulder height, then lower slowly.",
                Difficulty = "Beginner",
                BodyPart = "Shoulders",
                Goal = "Strength",
                Equipment = "Dumbbell",
                Location = "Gym",
                TargetMuscle = "Side Delts",
                ImageUrl = "/images/exercises/lateralraise.jpg",
                YouTubeVideoId = "3VcKaXpzqRo"
            },
            new Exercise
            {
                Id = 9,
                Name = "Bicep Curl",
                Description = "A simple arm exercise focused on the biceps.",
                Instructions = "Hold dumbbells at your sides, curl them upward without swinging, then lower under control.",
                Difficulty = "Beginner",
                BodyPart = "Arms",
                Goal = "Strength",
                Equipment = "Dumbbell",
                Location = "Home",
                TargetMuscle = "Biceps",
                ImageUrl = "/images/exercises/bicepcurl.jpg",
                YouTubeVideoId = "ykJmrZ5v0Oo"
            },
            new Exercise
            {
                Id = 10,
                Name = "Tricep Dips",
                Description = "A bodyweight movement for triceps and chest.",
                Instructions = "Use parallel bars or a bench, lower your body by bending your elbows, then push back up.",
                Difficulty = "Intermediate",
                BodyPart = "Arms",
                Goal = "Strength",
                Equipment = "Bench",
                Location = "Gym",
                TargetMuscle = "Triceps",
                ImageUrl = "/images/exercises/dips.jpg",
                YouTubeVideoId = "0326dy_-CzM"
            },
            new Exercise
            {
                Id = 11,
                Name = "Plank",
                Description = "A core exercise for stability and endurance.",
                Instructions = "Hold your body in a straight line on your forearms and toes while bracing your core.",
                Difficulty = "Beginner",
                BodyPart = "Core",
                Goal = "Balance",
                Equipment = "None",
                Location = "Home",
                TargetMuscle = "Abdominals",
                ImageUrl = "/images/exercises/plank.jpg",
                YouTubeVideoId = "ASdvN_XEl_c"
            },
            new Exercise
            {
                Id = 12,
                Name = "Hanging Leg Raise",
                Description = "A core movement that targets the lower abs and hip flexors.",
                Instructions = "Hang from a bar, raise your legs until parallel or higher, then lower slowly.",
                Difficulty = "Advanced",
                BodyPart = "Core",
                Goal = "Strength",
                Equipment = "Pull-Up Bar",
                Location = "Gym",
                TargetMuscle = "Lower Abs",
                ImageUrl = "/images/exercises/legraise.jpg",
                YouTubeVideoId = "Pr1ieGZ5atk"
            },
            new Exercise
            {
                Id = 13,
                Name = "Hip Thrust",
                Description = "A strong glute builder for power and muscle growth.",
                Instructions = "Rest your upper back on a bench, place the bar over your hips, drive through your heels, and squeeze your glutes at the top.",
                Difficulty = "Intermediate",
                BodyPart = "Glutes",
                Goal = "Strength",
                Equipment = "Barbell",
                Location = "Gym",
                TargetMuscle = "Glutes",
                ImageUrl = "/images/exercises/hipthrust.jpg",
                YouTubeVideoId = "LM8XHLYJoYs"
            },
            new Exercise
            {
                Id = 14,
                Name = "Glute Bridge",
                Description = "A beginner-friendly glute exercise.",
                Instructions = "Lie on your back with knees bent, drive your hips up, squeeze your glutes, then lower down.",
                Difficulty = "Beginner",
                BodyPart = "Glutes",
                Goal = "Mobility",
                Equipment = "None",
                Location = "Home",
                TargetMuscle = "Glutes",
                ImageUrl = "/images/exercises/glutebridge.jpg",
                YouTubeVideoId = "wPM8icPu6H8"
            },
            new Exercise
            {
                Id = 15,
                Name = "Burpees",
                Description = "A full-body conditioning exercise that combines strength and cardio.",
                Instructions = "Drop into a squat, kick your feet back, perform a push-up, jump your feet forward, and explode upward.",
                Difficulty = "Intermediate",
                BodyPart = "Full Body",
                Goal = "HIIT",
                Equipment = "None",
                Location = "Home",
                TargetMuscle = "Full Body",
                ImageUrl = "/images/exercises/burpees.jpg",
                YouTubeVideoId = "TU8QYVW0gDU"
            },
            new Exercise
            {
                Id = 16,
                Name = "Jump Rope",
                Description = "A simple cardio exercise that improves endurance and coordination.",
                Instructions = "Rotate the rope around your body and jump lightly over it while maintaining rhythm.",
                Difficulty = "Beginner",
                BodyPart = "Full Body",
                Goal = "Cardio",
                Equipment = "Jump Rope",
                Location = "Home",
                TargetMuscle = "Full Body",
                ImageUrl = "/images/exercises/jumprope.jpg",
                YouTubeVideoId = "1BZM8Cy-cEA"
            },
            new Exercise
            {
                Id = 17,
                Name = "Dynamic Hip Stretch",
                Description = "A mobility drill for better lower body movement.",
                Instructions = "Move through controlled hip opening and stretching motions before training.",
                Difficulty = "Beginner",
                BodyPart = "Legs",
                Goal = "Mobility",
                Equipment = "None",
                Location = "Home",
                TargetMuscle = "Hip Flexors",
                ImageUrl = "/images/exercises/hipstretch.jpg",
                YouTubeVideoId = "FSSDLDhbacc"
            },
            new Exercise
            {
                Id = 18,
                Name = "Hamstring Stretch",
                Description = "A flexibility movement to improve range of motion in the legs.",
                Instructions = "Keep one leg straight and gently lean forward until you feel a stretch in the hamstring.",
                Difficulty = "Beginner",
                BodyPart = "Legs",
                Goal = "Flexibility",
                Equipment = "None",
                Location = "Home",
                TargetMuscle = "Hamstrings",
                ImageUrl = "/images/exercises/hamstringstretch.jpg",
                YouTubeVideoId = "vKPGeO8Pj8U"
            },
            new Exercise
            {
                Id = 19,
                Name = "Box Jumps",
                Description = "An explosive plyometric exercise for lower body power.",
                Instructions = "Stand in front of a box, swing your arms, jump onto the box softly, then step down carefully.",
                Difficulty = "Intermediate",
                BodyPart = "Legs",
                Goal = "Plyometrics",
                Equipment = "Box",
                Location = "Gym",
                TargetMuscle = "Quadriceps",
                ImageUrl = "/images/exercises/boxjump.jpg",
                YouTubeVideoId = "52r_Ul5k03g"
            },
            new Exercise
            {
                Id = 20,
                Name = "Single-Leg Balance",
                Description = "A balance drill that improves coordination and ankle stability.",
                Instructions = "Stand on one leg while keeping your torso upright and your core engaged.",
                Difficulty = "Beginner",
                BodyPart = "Core",
                Goal = "Balance",
                Equipment = "None",
                Location = "Home",
                TargetMuscle = "Stabilizers",
                ImageUrl = "/images/exercises/singlelegbalance.jpg",
                YouTubeVideoId = "2Q9D7d4sR1A"
            }
        };

        public List<Exercise> GetAllExercises()
        {
            return _exercises;
        }

        public Exercise? GetExerciseById(int id)
        {
            return _exercises.FirstOrDefault(e => e.Id == id);
        }

        public List<Exercise> FilterExercises(string? bodyPart, string? goal, string? difficulty, string? equipment)
        {
            var query = _exercises.AsQueryable();

            if (!string.IsNullOrWhiteSpace(bodyPart))
            {
                query = query.Where(e => e.BodyPart.Equals(bodyPart, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(goal))
            {
                query = query.Where(e => e.Goal.Equals(goal, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(difficulty))
            {
                query = query.Where(e => e.Difficulty.Equals(difficulty, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(equipment))
            {
                query = query.Where(e => e.Equipment.Equals(equipment, StringComparison.OrdinalIgnoreCase));
            }

            return query.ToList();
        }
    }
}