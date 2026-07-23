using OnlineCourses.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Core.Repository
{
    public interface IEnrollmentRepository
    {
        public List<Enrollment> GetAll();
    }
}
