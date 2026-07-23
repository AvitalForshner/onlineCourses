using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineCourses.Core.Entities;
using OnlineCourses.Core.Repository;

namespace OnlineCourses.Data.Repositories
{
    public class CourseRepository: ICourseRepository
    {
        private readonly DataContext _context;
        public CourseRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Course>GetAll()
        {
            return _context.Courses.ToList();
        }
        public Course GetById(int id)
        {
            return _context.Courses.ToList().Find(c => c.Id == id);
        }
        public async Task PostAsync(Course c)
        {
            _context.Courses.Add(c);
            await _context.SaveChangesAsync();
        }
        public void Put(Course course)
        {
            Course c = _context.Courses.ToList().Find(c => c.Id == course.Id);
            if (c != null)
            {
                c.Title = course.Title;
                c.Description = course.Description;
                c.InstructorId = course.InstructorId;
            }
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            Course c = _context.Courses.ToList().Find(c => c.Id == id);
            if(c != null)
            {
                _context.Courses.Remove(c);
            }
            _context.SaveChanges();
        }
    }
}