using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace M1Assignment1.Models
{
    public class StudentCourse
    {
        [Key]
        public int CourseRegId { get; set; }

        [Required(ErrorMessage = "Please input StudentID")]
        //[Key]
        //[Column(Order = 0)]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Please input CourseID")]
        //[Key]
        //[Column(Order = 1)]
        public int CourseId { get; set; }
    }
}
