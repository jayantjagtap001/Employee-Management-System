namespace Employee_Management_System.Models
{
    public class UpdateRowData
    {
        public required String FirstName { get; set; }

        public required String LastName { get; set; }

        public required String Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public required String Position { get; set; }

        public required Double Salary { get; set; }
    }
}
