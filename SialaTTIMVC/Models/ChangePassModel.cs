
using System.ComponentModel.DataAnnotations;

namespace SialaTTIMVC.Models
{
    public class ChangePassModel
    {
        [Required]
        public string CurrentPassword { get; set; }
        [Required]
        public string NewPassword { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }
    }
}
