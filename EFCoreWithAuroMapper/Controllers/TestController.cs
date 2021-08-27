using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EFCoreWithAuroMapper.DTO;
using EFCoreWithAuroMapper.Model;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreWithAuroMapper.Controllers
{
    [Route("api/test")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly EFCoreWithAuroMapperContext _context;
        public TestController(EFCoreWithAuroMapperContext dbContext, IMapper mapper)
        {
            _context = dbContext;
            _mapper = mapper;
        }
        

        [HttpPost("add-teacher")]
        public ActionResult<Teacher> AddTeacher([FromBody] TeacherDTO dto)
        {
                var teacher = _mapper.Map<Teacher>(dto);

                _context.Teacher.Add(teacher);
                _context.SaveChangesAsync();
                return teacher;
        }


        [HttpGet("teachers")]
        public void GetAll()
        {
            try
            {
                var list = _context.Teacher.ToList();
                var tt=list;

            }
            catch (Exception ex)
            {

            }

        }
    }
}
