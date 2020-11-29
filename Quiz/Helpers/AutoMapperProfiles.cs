using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Quiz.DTOs;
using Quiz.Models;

namespace Quiz.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<UserToLoginDto, User>();
        }
    }
}
