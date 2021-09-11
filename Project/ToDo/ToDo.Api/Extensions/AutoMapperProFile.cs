using AutoMapper.Configuration;
using ToDo.Api.Context;
using ToDo.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Api.Extensions
{
    public class AutoMapperProFile : MapperConfigurationExpression
    {
        public AutoMapperProFile()
        {
            CreateMap<ToDoEntity, ToDoDto>().ReverseMap();
            CreateMap<MemoEntity, MemoDto>().ReverseMap();
            CreateMap<UserEntity, UserDto>().ReverseMap();
        }
    }
}
