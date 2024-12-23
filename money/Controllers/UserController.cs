using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
        /// <returns>
        ///     created user
        /// </returns>
        /// <response code="201">Returns the newly created user</response>
        /// <response code="400">If the user is missing atributes</response>
        [HttpPost(Name = "create user")]
        [ProducesResponseType(201, Type = typeof(CreateUserDto))]
        [ProducesResponseType(400, Type = typeof(ValidationErrorDto))]
        public IActionResult CreateUser([FromBody] CreateUserDto User) { 
            if (!ModelState.IsValid)
            {   
                return BadRequest(ValidationErrorDto.Gen(ModelState));
            }

            return new JsonResult(User) { StatusCode = 201 };
        }
    }
}
