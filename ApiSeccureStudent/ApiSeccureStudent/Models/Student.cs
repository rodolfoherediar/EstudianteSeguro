
namespace ApiSeccureStudent.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Student
    {
        [Key]
        [Range(1, 9999)]
        public int StudentID { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        public string LastName { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must contein between {2} and {1} characteres", MinimumLength = 2)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        public string FirstName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
    }
}