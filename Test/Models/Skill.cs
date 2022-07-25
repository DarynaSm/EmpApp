using System;
namespace Test.Models
{
    public class Skill:BaseIdModel
    {
        public string name { get; set; }
        public enum Level { Begginer, Intermidiate, Advanced}
        public int ResumeId { get; set; }
        
    }
}
