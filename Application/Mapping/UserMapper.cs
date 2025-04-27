using Application.DTOs.UserDTOs;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<User, UserCreateDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
