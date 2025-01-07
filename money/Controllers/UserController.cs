// <copyright file="UserController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Money.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Money.DTOs;
    using Money.Services;

    [ApiController]
    [Route("[controller]")]
    public class UserController(UserService userService) : ControllerBase
    {
        private readonly UserService userService = userService;

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
        /// <response code="400">If the user is missing attributes</response>
        [HttpPost(Name = "create user")]
        [ProducesResponseType(201, Type = typeof(UserResponseDTO))]
        [ProducesResponseType(400, Type = typeof(ValidationErrorDTO))]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserDTO createUserDTO)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(ValidationErrorDTO.Gen(this.ModelState));
            }

            try
            {
                return new JsonResult(await this.userService.Create(createUserDTO)) { StatusCode = 201 };
            }
            catch (Exception e)
            {
                return this.BadRequest(new { message = e.Message });
            }
        }
    }
}
