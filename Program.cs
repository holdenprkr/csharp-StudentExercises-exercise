using System;
using System.Collections.Generic;

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

            Instructor AdamS = new Instructor("Adam", "Sheaffer", "@adamsheaf", Day37)
            {
                Specialty = "Snacks"
            };
            AdamS.AssignExercise(MartinsAquarium, HoldenP);
            AdamS.AssignExercise(GlassdalePD, HoldenP);
            AdamS.AssignExercise(MartinsAquarium, DanielF);
            AdamS.AssignExercise(GlassdalePD, DanielF);
            AdamS.AssignExercise(MartinsAquarium, MattC);
            AdamS.AssignExercise(GlassdalePD, MattC);
            AdamS.AssignExercise(MartinsAquarium, SpencerT);
            AdamS.AssignExercise(GlassdalePD, SpencerT);

            Instructor MoS = new Instructor("Mo", "Silvera", "@Mo", Day39)
            {
                Specialty = "Dancing"
            };
            MoS.AssignExercise(PlanYourHeist, HoldenP);
            MoS.AssignExercise(Nutshell, HoldenP);
            MoS.AssignExercise(PlanYourHeist, DanielF);
            MoS.AssignExercise(Nutshell, DanielF);
            MoS.AssignExercise(PlanYourHeist, MattC);
            MoS.AssignExercise(Nutshell, MattC);
            MoS.AssignExercise(PlanYourHeist, SpencerT);
            MoS.AssignExercise(Nutshell, SpencerT);

            Instructor SteveB = new Instructor("Steve", "Brownlee", "@coach", Evening6)
            {
                Specialty = "Dad Jokes"
            };
            SteveB.AssignExercise(Nutshell, HoldenP);
            SteveB.AssignExercise(MartinsAquarium, HoldenP);
            SteveB.AssignExercise(Nutshell, DanielF);
            SteveB.AssignExercise(MartinsAquarium, DanielF);
            SteveB.AssignExercise(Nutshell, MattC);
            SteveB.AssignExercise(MartinsAquarium, MattC);
            SteveB.AssignExercise(Nutshell, SpencerT);
            SteveB.AssignExercise(MartinsAquarium, SpencerT);

            List<Student> AllStudents = new List<Student>();

            AllStudents.Add(SpencerT);
            AllStudents.Add(DanielF);
            AllStudents.Add(HoldenP);
            AllStudents.Add(MattC);

            foreach (Student student in AllStudents)
            {
                foreach (Exercise exercise in student.Exercises)
                {
                    Console.WriteLine($"{student.FirstName} is working on the {exercise.Name} {exercise.Language} exercise.");
                }
            }

        }
    }
}