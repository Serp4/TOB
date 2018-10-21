using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TOB.Models.DTO;
using TOB.Models.Entity;

namespace TOB.Other
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>().IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter();
            CreateMap<UserDto, User>().IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter();

        }
    }
}
