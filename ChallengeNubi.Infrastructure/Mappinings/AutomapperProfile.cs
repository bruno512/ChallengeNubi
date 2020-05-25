using AutoMapper;
using ChallengeNubi.Core.DTOs;
using ChallengeNubi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeNubi.Infrastructure.Mappinings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}
