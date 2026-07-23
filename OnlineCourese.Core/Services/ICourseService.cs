using OnlineCourses.Core.DTO;
using OnlineCourses.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Core.Services
{
    public interface ICourseService
    {
        public IEnumerable<CourseDTO> GetList();
        public CourseDTO GetCourseById(int id);
        public Task AddAsync(Course course);
        public void Update(Course course);
        public void DeleteCourse(int id);
    }
}
