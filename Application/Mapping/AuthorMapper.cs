using Application.DTOs.AuthorDTOs;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping
{
    public class AuthorMapper : Profile
    {
        public AuthorMapper()
        {
            CreateMap<Author, AuthorCreateDto>().ReverseMap();
            CreateMap<Author, AuthorUpdateDto>().ReverseMap();
        }
    }
}
