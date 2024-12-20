using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace money.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController
    {
        [HttpPost(Name = "create user")]
        public IActionResult createUser() {
            return new JsonResult(new {}) { StatusCode = 201 };
        }
        [HttpGet(Name = "userById")]
        public bool userById(int id)
        {
            return true;
        }
    }
}
