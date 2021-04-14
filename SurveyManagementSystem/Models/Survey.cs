using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace SurveyManagementSystem.Models
{
   public class Survey
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }


        [Required]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }



    }
}
