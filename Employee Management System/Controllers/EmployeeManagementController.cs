using Employee_Management_System.Data;
using Employee_Management_System.Models;
using Employee_Management_System.Models.Emp_Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employee_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeManagementController : ControllerBase
    {
        private readonly AppDbContexts dbData;

        public EmployeeManagementController(AppDbContexts DbData)
        {
            this.dbData = DbData;
        }

        [HttpGet]
        public IActionResult GetAllEmployeeData()
        {

            return Ok(dbData.Employees.ToList());
        }

        [HttpGet]
        [Route("{Id}:int")]

        public IActionResult GetSingleEmployeeById(int Id)
        {
            var SingleID = dbData.Employees.Find(Id);


            return Ok(SingleID);
        }



        [HttpPost]
        public IActionResult PostTheEmpData(PostRowDataStore addPostRow)
        {
            if (addPostRow == null)
            {
                return BadRequest("Employee data is required.");
            }

            var PostData = new Employee()
            {
                FirstName = addPostRow.FirstName,
                LastName = addPostRow.LastName,
                Email = addPostRow.Email,
                Position = addPostRow.Position,
                Salary = addPostRow.Salary,

            };

            dbData.Employees.Add(PostData);
            dbData.SaveChanges();
            return Ok(PostData);
        }

        [HttpPut]
        [Route("{Id}:int")]

        public IActionResult UpdateEmployeeData(int Id,UpdateRowData updateData)
        {
            var EmpUpdateId = dbData.Employees.Find(Id);

            EmpUpdateId.FirstName = updateData.FirstName;
            EmpUpdateId.LastName = updateData.LastName;
            EmpUpdateId.Email = updateData.Email;
            EmpUpdateId.DateOfBirth = updateData.DateOfBirth;
            EmpUpdateId.Position = updateData.Position;
            EmpUpdateId.Salary = updateData.Salary;

            dbData.SaveChanges();
            return Ok(EmpUpdateId);

        }

        [HttpDelete]
        [Route("{Id}:int")]

        public IActionResult DeleteDataEmployee(int Id)
        {
            var EmpDelete = dbData.Employees.Find(Id);

            dbData.Employees.Remove(EmpDelete);

            dbData.SaveChanges();

            return Ok("Here Data is Deleted Thank You....!");

        }
    }
}
