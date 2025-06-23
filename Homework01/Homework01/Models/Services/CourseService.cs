using Homework01.Models.Db;
using Homework01.Models.Dtos;
using Homework01.Models.Entities;

namespace Homework01.Models.Services
{
    public class CourseService
    {
        public List<ListCourseNameDto> GetAllCoursesNames()
        {
            return InMemoryDb.Courses.Select(course =>
           new ListCourseNameDto
           {
               Name = $"{course.Name}"
           }).ToList();
        }

        public ListCourseByIdDto GetCourseById(int id)
        {
            Course course = InMemoryDb.Courses.SingleOrDefault(x => x.Id == id);

            if (course == null)
                return null;

            ListCourseByIdDto courseById = new ListCourseByIdDto()
            {
                Id = course.Id,
                Name = course.Name,
                NumberOfClasses = course.NumberOfClasses
            };

            return courseById;
        }
    }
}
