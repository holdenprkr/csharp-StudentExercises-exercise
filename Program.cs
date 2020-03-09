using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise MartinsAquarium = new Exercise("MartinsAquarium", "JavaScript");
            Exercise PlanYourHeist = new Exercise("Plan Your Heist", "C#");
            Exercise GlassdalePD = new Exercise("Glassdale PD", "JavaScript");
            Exercise Nutshell = new Exercise("Nutshell", "React");

            Cohort Day37 = new Cohort("Day Cohort 37");
            Cohort Day39 = new Cohort("Day Cohort 39");
            Cohort Evening6 = new Cohort("Evening Cohort 6");

            Student SpencerT = new Student("Spencer", "Truett", "@Spencer Truett", Day37);
            Student DanielF = new Student("Daniel", "Fuqua", "@Daniel Fuqua", Day39);
            Student HoldenP = new Student("Holden", "Parker", "@Holden Parker", Day37);
            Student MattC = new Student("Matt", "Crook", "@Matt Crook", Evening6);
            Student DouieN = new Student("Douie", "Notheen", "@DoesNothing", Evening6);

            Instructor AdamS = new Instructor("Adam", "Sheaffer", "@adamsheaf", Day37)
            {
                Specialty = "Snacks"
            };
            AdamS.AssignExercise(MartinsAquarium, HoldenP);
            AdamS.AssignExercise(GlassdalePD, HoldenP);
            AdamS.AssignExercise(Nutshell, HoldenP);
            AdamS.AssignExercise(MartinsAquarium, SpencerT);
            AdamS.AssignExercise(GlassdalePD, SpencerT);

            Instructor MoS = new Instructor("Mo", "Silvera", "@Mo", Day39)
            {
                Specialty = "Dancing"
            };
            MoS.AssignExercise(PlanYourHeist, DanielF);
            MoS.AssignExercise(Nutshell, DanielF);

            Instructor SteveB = new Instructor("Steve", "Brownlee", "@coach", Evening6)
            {
                Specialty = "Dad Jokes"
            };
            SteveB.AssignExercise(Nutshell, MattC);
            SteveB.AssignExercise(MartinsAquarium, MattC);

            var AllStudents = new List<Student>()
            {
                SpencerT,
                DanielF,
                HoldenP,
                MattC,
                DouieN
            };

            var AllExercises = new List<Exercise>()
            {
                Nutshell,
                MartinsAquarium,
                GlassdalePD,
                PlanYourHeist
            };

            var AllInstructors = new List<Instructor>()
            {
                AdamS,
                SteveB,
                MoS
            };

            var AllCohorts = new List<Cohort>()
            {
                Day37,
                Day39,
                Evening6
            };

            foreach (Student student in AllStudents)
            {
                foreach (Exercise exercise in student.Exercises)
                {
                    Console.WriteLine($"{student.FirstName} is working on the {exercise.Name} {exercise.Language} exercise in {student.Cohort.Name}.");
                }
            }

            var javaScriptExercises = AllExercises.Where(exercise => exercise.Language == "JavaScript");

            foreach (var exercise in javaScriptExercises)
            {
                Console.WriteLine($"JavaScript exercise: {exercise.Name}");
            }

            var day37Students = AllStudents.Where(student => student.Cohort == Day37);

            foreach (var student in day37Students)
            {
                Console.WriteLine($"Student in day cohort 37: {student.FirstName} {student.LastName}");
            }

            var day37Instructors = AllInstructors.Where(instructor => instructor.Cohort == Day37);

            foreach (var instructor in day37Instructors)
            {
                Console.WriteLine($"Instructor in day cohort 37: {instructor.FirstName} {instructor.LastName}");
            }

            var studentsByLastName = AllStudents.OrderBy(student => student.LastName);

            Console.WriteLine("Students ordered by last name:");
            foreach (var student in studentsByLastName)
            {
                Console.Write($"{student.FirstName} {student.LastName} ");
            }

            var studentsNotWorking = AllStudents.Where(student => student.Exercises.Count() == 0);

            foreach (var student in studentsNotWorking)
            {
                Console.WriteLine($"Students not working on any exercises: {student.FirstName} {student.LastName}");
            }

            var descendStudentMostExercises = AllStudents.OrderByDescending(student => student.Exercises.Count());
            var studentMostExercises = descendStudentMostExercises.First();

            Console.WriteLine($"{studentMostExercises.FirstName} {studentMostExercises.LastName} is currently working on the most exercises.");

            var groups = AllStudents.GroupBy(student => student.Cohort.Name);

            foreach (var group in groups)
            {
                Console.WriteLine($"There are {group.Count()} students in {group.Key}.");
            }

        }
    }
}