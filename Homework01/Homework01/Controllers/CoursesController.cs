using Homework01.Models.Dtos;
using Homework01.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace Homework01.Controllers
{
    [Route("courses")]
    public class CoursesController : Controller
    {
        private CourseService _courseService;

        public CoursesController()
        {
            _courseService = new CourseService();
        }
        [HttpGet("{id}")]
        public IActionResult GetCourseById(int id)
        {
            ListCourseByIdDto course = _courseService.GetCourseById(id);

            if (course == null)
                return Content("Error bratce");

            return Json(course);
        }
        public IActionResult GetAllCoursesNames()
        {
            List<ListCourseNameDto> courses = _courseService.GetAllCoursesNames();
            return Json(courses);
        }
    }
}
