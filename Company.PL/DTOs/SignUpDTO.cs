using System.ComponentModel.DataAnnotations;

namespace Company.PL.DTOs
{
    public class SignUpDTO
    {
        [Required(ErrorMessage = "FirstName Is Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName Is Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "UserName Is Required")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Email Is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password Is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "ConfirmPassword Is Required")]
        [DataType(DataType.Password)]

        [Compare("Password", ErrorMessage = "Password And ConfirmPassword Do Not Match")]
        public string ConfirmPassword { get; set; }
        public bool IsAgree { get; set; }
    }
}
