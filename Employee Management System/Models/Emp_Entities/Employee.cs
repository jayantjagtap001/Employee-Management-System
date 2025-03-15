using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Employee_Management_System.Models.Emp_Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public required String  FirstName { get; set; }

        public required String  LastName { get; set; }

        public required String Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public required String Position { get; set; }

        public required Double Salary { get; set; }

    }
}
