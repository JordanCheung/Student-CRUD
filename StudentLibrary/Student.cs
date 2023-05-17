using System;
using System.ComponentModel.DataAnnotations;

namespace StudentLibrary
{
    public class Student
    {
        [Key]
        [Display(Name = "BCIT ID")]
        [RegularExpression("^[A][0-9]{8}$", ErrorMessage = "BCIT ID must have the format A00123456")]
        public string BcitId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        [RegularExpression("^[A-Za-z -]+$", ErrorMessage = "First Name can only contain alphabets, space or -")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [RegularExpression("^[A-Za-z -]+$", ErrorMessage = "Last Name can only contain alphabets, space or -")]
        public string LastName { get; set; }
        [Required]
        [RegularExpression("^[0-9]{3}[-][0-9]{3}[-][0-9]{4}$", ErrorMessage="Phone Number must be in the format 123-456-7890")]
        [Display(Name = "Mobile Number")]
        public string MobileNumber { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Email address must be in a email format")]
        public string EmailAddress { get; set; }
        [Required]
        [Display(Name = "City Of Residence")]
        [RegularExpression("^[A-Za-z0-9 -]+$", ErrorMessage = "City of residence can only contain alphabets, numbers, space or -")]
        public string CityOfResidence { get; set; }
        [Required]
        [RegularExpression("^[A-Za-z -]+$", ErrorMessage = "Specialization can only contain alphabets, space or -")]
        public string Specialization { get; set; }
    }
}
