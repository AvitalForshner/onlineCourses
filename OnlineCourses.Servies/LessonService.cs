using OnlineCourses.Core.Entities;
using OnlineCourses.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineCourses.Core.Services;
using AutoMapper;
using OnlineCourses.Core.DTO;
namespace OnlineCourse.Service
{
    public class LessonService:ILessonService
    {
        private readonly ILessonRepository _LessonRepository;
        private readonly IMapper _mapper;
        public LessonService(ILessonRepository LessonRepository,IMapper mapper)
        {
            _LessonRepository = LessonRepository;
            _mapper = mapper;
        }
        public IEnumerable<LessonDTO> GetList()
        {
            //TODO bussiness logic
            var lessons = _LessonRepository.GetAll();
            var lessonsDtO = _mapper.Map<IEnumerable<LessonDTO>>(lessons);
            return lessonsDtO;
        }
    }
}