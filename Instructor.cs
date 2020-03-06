using System.Collections.Generic;

namespace StudentExercises
{
    public class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public string Specialty { get; set; }

        public Instructor(string first, string last, string slack, Cohort cohort)
        {
            FirstName = first;
            LastName = last;
            SlackHandle = slack;
            Cohort = cohort;
        }

        public void AssignExercise(Exercise exercise, Student student)
        {
            student.Exercises.Add(exercise);
        }
    }
}