using System;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class BaseIdModel
    {
        [Key]
        public int Id { get; set; }
    }
}
