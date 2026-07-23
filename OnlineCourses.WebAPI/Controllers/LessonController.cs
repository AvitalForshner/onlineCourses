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
    public class LessonsController : ControllerBase
    {
        private readonly ILessonService _lessonService;
        public LessonsController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }
        // GET: api/<LessonsController>
        [HttpGet]
        public IEnumerable<LessonDTO> Get()
        {
            return _lessonService.GetList();
        }

        // GET api/<LessonsController>/5
        //[HttpGet("{id}")]
        //public Lesson Get(int id)
        //{
        //    return _context.Lessons.Find(l => l.Id == id);
        //}

        //// POST api/<LessonsController>
        //[HttpPost]
        //public void Post([FromBody] Lesson lesson)
        //{
        //    _context.Lessons.Add(lesson);
        //}

        //// PUT api/<LessonsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] Lesson updated)
        //{
        //    Lesson l = _context.Lessons.Find(l => l.Id == id);
        //    if (l != null)
        //    {
        //        l.Title = updated.Title;
        //        l.VideoUrl = updated.VideoUrl;
        //        l.CourseId = updated.CourseId;
        //        l.Order = updated.Order;
        //    }
        //}

        //// DELETE api/<LessonsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //    Lesson l = _context.Lessons.Find(l => l.Id == id);
        //    if (l != null)
        //    {
        //        _context.Lessons.Remove(l);
        //    }
        //}
    }
}