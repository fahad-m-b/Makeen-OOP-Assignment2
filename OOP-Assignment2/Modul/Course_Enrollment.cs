using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment2.Modul
{

    public enum Level
    {
        Begginer,
        Intermediate,
        Advanced
    }
    public class Course_Enrollment
    {
        public Course_Enrollment(string name, string instructor, Level level)
        {
            Name = name;
            Instructor = instructor;
            this.level = level;
        }

        public string Name { get; set; }
        public string Instructor { get; set; }
        public Level level { get; set; }
    }
    public class VideoCourse : Course_Enrollment
    {
        public int Duration { get; set; }

        public VideoCourse(string name, string instructor, Level level, int Duration) :base(name,instructor, level)
        {
            this.Duration = Duration;
        }
    }
    public class LiveSession : Course_Enrollment
    {
        public string DateTime { get; set; }

        public LiveSession(string name, string instructor, Level level, string DateTime) : base(name, instructor, level)
        {
            this.DateTime = DateTime;
        }
    }
    public class CourseCatalog
    {
        private List<Course_Enrollment> courses = new List<Course_Enrollment>();

        public void AddCourse(Course_Enrollment course)
        {
            courses.Add(course);
        }
        public List<Course_Enrollment> this[Level lvl]
        {
            get
            {
                List<Course_Enrollment> result = new List<Course_Enrollment>();

                foreach (Course_Enrollment c in courses)
                {
                    if(c.level == lvl)
                    {
                        result.Add(c);
                    }
                }
                return result;
            }
        }
    }
}
