// <copyright file="CreateUserDto.cs" company="NickInc">
// Copyright (c) NickInc. All rights reserved.
// </copyright>

namespace Money.DTOs
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// create use dto.
    /// </summary>
    public class CreateUserDTO
    {
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        /// <example>Nícolas Krüger</example>
        [Required(ErrorMessage = "name required")]
        [Length(5, 100, ErrorMessage = "name to need to be more than 5 or less than 100")]
        required public string Name { get; set; }

        /// <summary>
        /// Gets or sets email.
        /// </summary>
        /// <example>sample@email.com</example>
        [Required(ErrorMessage = "email required")]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "not valid email")]
        required public string Email { get; set; }

        /// <summary>
        /// Gets or sets password.
        /// </summary>
        /// <example>password1.</example>
        [Required(ErrorMessage = "password required")]
        [RegularExpression(@"^(?=.*\d).{8,}$", ErrorMessage = "password must have 8 length and one digit")]
        required public string Password { get; set; }

    }
}
