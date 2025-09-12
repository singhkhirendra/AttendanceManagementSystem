using Application.DTOs;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Example: Domain User -> DTO
            CreateMap<User, UserCreateDto>().ReverseMap();
            CreateMap<UserUpdateDto, User>();
        }
    }
}
