using System.ComponentModel.DataAnnotations;
namespace SialaTTIMVC.Models
{
    public class LoginModel
    {
        [Required]
        public string? StudentNumber { get; set; }
        [Required]
        public string? Password {  get; set; }
    }
}
