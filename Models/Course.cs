using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace M1Assignment1.Models
{
    public class Course
    {
        //CourseId, Course Number, Course Name, and Description
        [Key]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "Please input Course Number"), MaxLength(50, ErrorMessage = "Limited in 50 chr")]
        public string CourseNumber { get; set; }

        [Required(ErrorMessage = "Please input Course Name"), MaxLength(50, ErrorMessage = "Limited in 50 chr")]
        public string CourseName { get; set; }
        public string Description { get; set; }

    }
}
