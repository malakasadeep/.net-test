using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private static List<User> Users = new List<User>
    {
        new User { Id = 1, FirstName = "John", LastName = "Doe", Address = "123 Elm Street", Mobile = "1234567890", Email = "john.doe@example.com", Department = "HR", Designation = "Manager", UpdatedBy = "J", Updated = DateTime.Now },
        // Add more sample users
        new User { Id = 2, FirstName = "Jane", LastName = "Smith", Address = "456 Maple Avenue", Mobile = "9876543210", Email = "jane.smith@example.com", Department = "Finance", Designation = "Accountant" , UpdatedBy = "J", Updated = DateTime.Now },
        new User { Id = 3, FirstName = "Michael", LastName = "Johnson", Address = "789 Oak Drive", Mobile = "1231231234", Email = "michael.johnson@example.com", Department = "IT", Designation = "Developer", UpdatedBy = "J", Updated = DateTime.Now },
        new User { Id = 4, FirstName = "Emily", LastName = "Davis", Address = "321 Birch Lane", Mobile = "9879879876", Email = "emily.davis@example.com", Department = "Marketing", Designation = "Executive" , UpdatedBy = "J", Updated = DateTime.Now },
        new User { Id = 5, FirstName = "William", LastName = "Brown", Address = "654 Pine Boulevard", Mobile = "4564564567", Email = "william.brown@example.com", Department = "Sales", Designation = "Sales Manager", UpdatedBy = "J", Updated = DateTime.Now },
        new User { Id = 6, FirstName = "Olivia", LastName = "Jones", Address = "789 Cedar Street", Mobile = "7897897891", Email = "olivia.jones@example.com", Department = "Admin", Designation = "Administrator", UpdatedBy = "J", Updated = DateTime.Now },
        new User { Id = 7, FirstName = "James", LastName = "Garcia", Address = "123 Spruce Avenue", Mobile = "3213213210", Email = "james.garcia@example.com", Department = "Operations", Designation = "Supervisor", UpdatedBy = "J", Updated = DateTime.Now },
        new User { Id = 8, FirstName = "Sophia", LastName = "Martinez", Address = "456 Willow Court", Mobile = "6546546548", Email = "sophia.martinez@example.com", Department = "HR", Designation = "Recruiter", UpdatedBy = "J", Updated = DateTime.Now },
        new User { Id = 9, FirstName = "Alexander", LastName = "Lee", Address = "789 Aspen Road", Mobile = "9871234567", Email = "alexander.lee@example.com", Department = "Legal", Designation = "Advisor", UpdatedBy = "J", Updated = DateTime.Now },
        new User { Id = 10, FirstName = "Isabella", LastName = "Clark", Address = "321 Redwood Terrace", Mobile = "4567891230", Email = "isabella.clark@example.com", Department = "R&D", Designation = "Researcher", UpdatedBy = "J", Updated = DateTime.Now },
        new User { Id = 11, FirstName = "Ethan", LastName = "Harris", Address = "654 Elmwood Lane", Mobile = "3216549870", Email = "ethan.harris@example.com", Department = "Logistics", Designation = "Coordinator", UpdatedBy = "J", Updated = DateTime.Now },
        new User { Id = 12, FirstName = "Ava", LastName = "Walker", Address = "123 Oakwood Drive", Mobile = "7893216541", Email = "ava.walker@example.com", Department = "Finance", Designation = "Analyst", UpdatedBy = "J", Updated = DateTime.Now },
    };

    [HttpGet]
    public ActionResult<IEnumerable<User>> GetUsers()
    {
        return Ok(Users);
    }
    }
}