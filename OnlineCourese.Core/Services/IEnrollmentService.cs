using OnlineCourses.Core.DTO;
using OnlineCourses.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Core.Services
{
    public interface IEnrollmentService
    {
        public IEnumerable<EnrollmentDTO> GetList();
    }
}
