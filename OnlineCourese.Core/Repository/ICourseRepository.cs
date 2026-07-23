using OnlineCourses.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Core.Repository
{
    public interface ICourseRepository
    {
        public IEnumerable<Course> GetAll();
        public Course GetById(int id);
        public Task PostAsync(Course c);
        public void Put(Course course);
        public void Delete(int id);
    }
}