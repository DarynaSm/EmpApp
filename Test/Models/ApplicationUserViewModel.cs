using System;
using System.Collections.Generic;

namespace Test.Models
{
    public class ApplicationUserViewModel:ApplicationUser
    {
        public ApplicationUserViewModel()
        {
        }
        public string City { get; set; }
        public string Age { get; set; }
        public List<Resume> Resumes { get; set; }
    }
}
