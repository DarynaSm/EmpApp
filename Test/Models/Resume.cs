using System;
using System.Collections.Generic;

namespace Test.Models
{
    public class Resume:BaseIdModel
    {
        public int UserId { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Experience> Experiences { get; set; }

        public Resume()
        {
        }
    }
}
