using Microsoft.AspNetCore.Mvc;
using money.Dto;

namespace money.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController: Controller
    {
        /// <summary>
        /// Create User 
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Todo
        ///     {
        ///        "name": "Nícolas Krüger",
        ///        "email": "sample@email.com",
        ///        "password": "password1"
        ///     }
        ///
        /// </remarks>
        /// <response code="201">Returns the newly created user</response>
        /// <response code="400">If the user is missing atributes</response>
        [HttpPost(Name = "create user")]
        public IActionResult CreateUser([FromBody] CreateUserDto User) {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return new JsonResult(User) { StatusCode = 201 };
        }
    }
}
