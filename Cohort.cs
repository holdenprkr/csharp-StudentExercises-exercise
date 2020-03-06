using System.Collections.Generic;

namespace StudentExercises
{
    public class Cohort
    {
        public string Name { get; set; }

        // public List<Student> Students = new List<Student>();
        // public List<Instructor> Instructors = new List<Instructor>();

        public Cohort(string name)
        {
            Name = name;
        }
    }
}