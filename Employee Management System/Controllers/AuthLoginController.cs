using Employee_Management_System.Models.Emp_Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Employee_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthLoginController : ControllerBase
    {
        private readonly IConfiguration config;

        public AuthLoginController(IConfiguration config)
        {
            this.config = config;
        }

        [HttpPost]
        public IActionResult LoginData([FromBody] UserLogin user)
        {
            if(user.UserName=="Jayant" && user.Password=="Pass123")
            {
                var Token = GenerateJwtToken(user.UserName);
                return Ok(new { Token });
            }

            return Unauthorized("Provide valid UserName and Password");
        }

        private String GenerateJwtToken(String username )
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:Key"]!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
            {
               new Claim(ClaimTypes.Name, username),
               new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
            issuer: config["Jwt:EmployeeUser1"],
            audience: config["Jwt:EmployeeUser2"],
            claims: claims,
            expires: DateTime.Now.AddMinutes(30),
            signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
