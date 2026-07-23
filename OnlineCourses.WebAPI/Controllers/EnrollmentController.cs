using Microsoft.AspNetCore.Mvc;
using OnlineCourses.Core.DTO;
using OnlineCourses.Core.Entities;
using OnlineCourses.Core.Services;
using OnlineCourses.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineCourses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        private readonly IEnrollmentService _enrollmentService;
        public EnrollmentController(IEnrollmentService enrollmentService)
        {
            _enrollmentService = enrollmentService;
        }
        // GET: api/<EnrollmentController>
        [HttpGet]
        public IEnumerable<EnrollmentDTO> Get()
        {
            return _enrollmentService.GetList();
        }

        // GET api/<EnrollmentController>/5
        //[HttpGet("{id}")]
        //public Enrollment Get(int id)
        //{
        //    return _Context.Enrollments.Find(e => e.Id == id);
        //}

        //// POST api/<EnrollmentController>
        //[HttpPost]
        //public void Post([FromBody] Enrollment enrollment)
        //{
        //    _Context.Enrollments.Add(enrollment);
        //}

        //// PUT api/<EnrollmentController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] Enrollment updated)
        //{
        //    Enrollment e = _Context.Enrollments.Find(e => e.Id == id);
        //    if (e != null)
        //    {
        //        e.UserId = updated.UserId;
        //        e.CourseId = updated.CourseId;
        //    }
        //}

        //// DELETE api/<EnrollmentController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //    Enrollment e = _Context.Enrollments.Find(e => e.Id == id);
        //    if (e != null)
        //    {
        //        _Context.Enrollments.Remove(e);
        //    }
        //}
    }
}
