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
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserCreateDto, User>()
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => DateTime.UtcNow));

            CreateMap<UserUpdateDto, User>();

            CreateMap<User, UserResponseDto>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));
                //.ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role.RoleName))
                //.ForMember(dest => dest.Organization, opt => opt.MapFrom(src => src.Organization.Name));
        }
    }
}
