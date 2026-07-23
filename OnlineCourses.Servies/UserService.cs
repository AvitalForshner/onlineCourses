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
    public class UserService:IUserService
    {
        private readonly IUserRepository _UserRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository UserRepository,IMapper mapper)
        {
            _UserRepository = UserRepository;
            _mapper = mapper;
        }
        public IEnumerable<UserDTO> GetList()
        {
            //TODO bussiness logic
            var users = _UserRepository.GetAll();
            var userDtO = _mapper.Map<IEnumerable<UserDTO>>(users);
            return userDtO;
        }
    }
}
