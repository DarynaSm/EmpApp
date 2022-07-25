using System;
using Microsoft.AspNetCore.Identity;

namespace Test.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string city { get; set; }
        public int age { get; set; }
        public Resume Resume { get; set; }
    }
}
