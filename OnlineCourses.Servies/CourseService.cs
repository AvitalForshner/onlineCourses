using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using OnlineCourses.Core.DTO;
using OnlineCourses.Core.Entities;
using OnlineCourses.Core.Repository;
using OnlineCourses.Core.Services;
namespace OnlineCourses.Service
{
    public class CourseService:ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;
        public CourseService(ICourseRepository courseRepository,IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }
        public IEnumerable<CourseDTO> GetList()
        {
            //TODO bussiness logic
            var courses = _courseRepository.GetAll();
            var coursesDtO = _mapper.Map<IEnumerable<CourseDTO>>(courses);
            return coursesDtO;
        }
        public CourseDTO GetCourseById(int id)
        {
            //TODO
            var course = _courseRepository.GetById(id);
            return _mapper.Map<CourseDTO>(course);
        }

        public async Task AddAsync(Course course)
        {
           await _courseRepository.PostAsync(course);
        }
        public void Update(Course course)
        {
            _courseRepository.Put(course);
        }
        public void DeleteCourse(int id)
        {
            _courseRepository.Delete(id);
        }
    }
}