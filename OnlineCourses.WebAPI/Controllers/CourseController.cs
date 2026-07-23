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
    public class CourseController : ControllerBase
    {

        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService= courseService;
        }
        // GET: api/<CourseController>
        [HttpGet]
        public ActionResult<IEnumerable<CourseDTO>> Get()
        {
            return Ok(_courseService.GetList());
        }

        //GET api/<CourseController>/5
        [HttpGet("{id}")]
        public ActionResult<CourseDTO> Get(int id)
        {
            var c=_courseService.GetCourseById(id);
            return Ok(c);
        }

        // POST api/<CourseController>
        [HttpPost]
        public async Task <ActionResult> Post([FromBody] Course course)
        {
            if (course == null)
            {
                return BadRequest();
            }
            await _courseService.AddAsync(course);
            return CreatedAtAction(nameof(Get), new { id=course.Id}, course);
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Course updated)
        {
            var c = _courseService.GetCourseById(id);
            if (c == null)
            {
                return NotFound();
            }
            _courseService.Update(updated);
            return NoContent();
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var c = _courseService.GetCourseById(id);
            if(c == null)
            {
                return NotFound();
            }
            _courseService.DeleteCourse(id);
            return NoContent();
        }
    }
}