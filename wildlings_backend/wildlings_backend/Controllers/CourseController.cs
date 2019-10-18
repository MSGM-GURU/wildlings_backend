using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using wildlings_backend.Models;
using wildlings_backend.Models.Service;
using wildlings_backend.Models.Service.Interface;

namespace wildlings_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private CourseService _courseService;

        public CourseController()
        {
            _courseService = new CourseService();
        }

        [HttpGet]
        public IEnumerable<Course> GetCourse()
        {
            return _courseService.GetAllCourse();
        }

        [HttpPost]
        public IActionResult Register(int customerId, int courseId)
        {
            _courseService.Register(customerId, courseId);
            return Ok();
        }
        [HttpPost]
        public IActionResult Cancel(int customerId, int courseId)
        {
            _courseService.Cancel(customerId, courseId);

            return Ok();
        }
        [HttpPost]
        public IActionResult Renew(int customerId, int courseId)
        {
            _courseService.Renew(customerId, courseId);

            return Ok();
        }
    }
}