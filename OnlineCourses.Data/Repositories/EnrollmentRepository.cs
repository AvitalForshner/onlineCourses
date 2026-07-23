using OnlineCourses.Core.Entities;
using OnlineCourses.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Data.Repositories
{
    public class EnrollmentRepository:IEnrollmentRepository
    {
        private readonly DataContext _context;
        public EnrollmentRepository(DataContext context)
        {
            _context = context;
        }
        public List<Enrollment> GetAll()
        {
            return _context.Enrollments.ToList();
        }
    }
}
