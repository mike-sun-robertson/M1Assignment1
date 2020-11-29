using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace M1Assignment1.Models
{
    public class Student
    {
        //StudentId, First Name, Last Name, Email address, and Phone number.
        [Key]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Please input First Name"), MaxLength(50, ErrorMessage = "Limited in 50 chr")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please input Last Name"), MaxLength(50, ErrorMessage = "Limited in 50 chr")]
        public String LastName { get; set; }
        [Required(ErrorMessage = "Please input E-mail Address")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Incorrect E-mail Address")]
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Course { get; set; }

    }
}
