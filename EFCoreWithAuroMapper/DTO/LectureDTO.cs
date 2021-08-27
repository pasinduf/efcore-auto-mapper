using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreWithAuroMapper.DTO
{
    public class LectureDTO :BaseEntityDTO
    {

        public int TeacherId { get; set; }
       
        public int SubjectId { get; set; }

        public int Duration { get; set; }
    }
}
