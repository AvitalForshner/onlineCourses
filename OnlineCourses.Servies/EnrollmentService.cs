using AutoMapper;
using OnlineCourses.Core.DTO;
using OnlineCourses.Core.Entities;
using OnlineCourses.Core.Repository;
using OnlineCourses.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourse.Service
{
    public class EnrollmentService:IEnrollmentService
    {
        private readonly IEnrollmentRepository _EnrollmentRepository;
        private readonly IMapper _mapper;
        public EnrollmentService(IEnrollmentRepository EnrollmentRepository,IMapper mapper)
        {
            _EnrollmentRepository = EnrollmentRepository;
            _mapper = mapper;
        }
        public IEnumerable<EnrollmentDTO> GetList()
        {
            //TODO bussiness logic
            var enrollments = _EnrollmentRepository.GetAll();
            var EnrollmentsDtO = _mapper.Map<IEnumerable<EnrollmentDTO>>(enrollments);
            return EnrollmentsDtO;
        }
    }
}
