using AutoMapper;
using EFCoreWithAuroMapper.DTO;
using EFCoreWithAuroMapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreWithAuroMapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<TeacherDTO, Teacher>();
            CreateMap<SubjectDTO,Subject>();
        }

    }
}
