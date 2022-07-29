﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Test.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string City { get; set; }
        public int Age { get; set; }
        public List<Resume> Resumes { get; set; }
    }
}
