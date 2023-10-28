using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Project.DTOLayer.DTOS.AdminDTOs
{
    public class SignUpVM
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Mail { get; set; }

        [Required]
        public IFormFile Image { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Password Incorrect.")]
        public string ConfirmPassword { get; set; }
    }
}
