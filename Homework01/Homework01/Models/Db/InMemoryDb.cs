using Homework01.Models.Entities;

namespace Homework01.Models.Db
{
    public static class InMemoryDb
    {
        public static List<Course> Courses { get; set; }
        static InMemoryDb()
        {
            LoadCourses();
        }

        private static void LoadCourses()
        {

            Courses = new List<Course>()
            {
                new Course()
                {
                    Id = 1,
                    Name = "C# Basic",
                    NumberOfClasses = 10
                },
                 new Course()
                {
                    Id = 2,
                    Name = "C# Advanced",
                    NumberOfClasses = 15
                },
                new Course()
                {
                    Id = 3,
                    Name = "ASP.NET Core",
                    NumberOfClasses = 10
                }
            };
        }

    }
}
