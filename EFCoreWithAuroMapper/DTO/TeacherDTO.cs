using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreWithAuroMapper.DTO
{
    public class TeacherDTO : BaseEntityDTO
    {
        public string Name { get; set; }

        public int Age { get; set; }

    }
}
