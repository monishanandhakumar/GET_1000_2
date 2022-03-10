using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prjMVCDay4.MyModel
{
    public class Register
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="UserName is Required")]
        [Display(Name="UserName")]
        public string UName{ get; set; }

        [Required(ErrorMessage = "DateOfBirth is Required")]
        [Display(Name = "DateOfBirth")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
      [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Please Enter ConfirmPassword")]
       [Compare("Password",ErrorMessage ="Password and ConfirmPassword should be same")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
       [EmailAddress]
        public string Email { get; set; }
    }
}
