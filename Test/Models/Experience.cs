using System;
namespace Test.Models
{
    public class Experience:BaseIdModel
    {
        public int ResumeId { get; set; }
        public string CompanyName { get; set; }
        public int Years { get; set; }

        public Experience()
        {
        }
    }
}
