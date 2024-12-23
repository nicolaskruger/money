using Microsoft.AspNetCore.Mvc;
using money.Dto;
using money.Dtos;
using money.Services;

namespace money.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController(UserService userService) : Controller
    {
        private readonly UserService _userService = userService;

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
        [ProducesResponseType(201, Type = typeof(UserResponseDto))]
        [ProducesResponseType(400, Type = typeof(ValidationErrorDto))]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserDto createUserDto) { 
            if (!ModelState.IsValid)
            {   
                return BadRequest(ValidationErrorDto.Gen(ModelState));
            }
            return new JsonResult(await _userService.create(createUserDto)) { StatusCode = 201 };
        }
    }
}
