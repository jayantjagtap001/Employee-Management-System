using System.ComponentModel.DataAnnotations;

namespace Employee_Management_System.Models.Emp_Entities
{
    public class UserLogin
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String UserName { get; set; } = String.Empty;

        [Required]
        public String Password { get; set; } = String.Empty;
    }
}
