using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StudentRegistration.Models
{
    public class Student
    {
        [Display(Name = "ID")]
        public int StudentID { get; set; }
        [Display(Name = "Name")]
        public string StudentName { get; set; }
        [Display(Name = "Cell Phone Number")]
        public string StudentCellPhone { get; set; }
        [Display(Name = "Age")]
        public int StudentAge { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string StudentEmail { get; set; }


    }
}
