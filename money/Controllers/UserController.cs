using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using money.Dto;
using System.Net;

namespace money.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController
    {
        [HttpPost(Name = "create user")]
        public IActionResult CreateUser([FromBody] CreateUserDto User) {
            return new JsonResult(User) { StatusCode = 201 };
        }
    }
}
