using System.ComponentModel.DataAnnotations;

namespace money.Dto
{
    /// <summary>
    /// create use dto
    /// </summary>
    public class CreateUserDto
    {
        /// <summary>
        /// name
        /// </summary>
        /// <example>Nícolas Krüger</example>
        [Required(ErrorMessage = "name required")]
        [Length(5, 100, ErrorMessage = "name to need to be more than 5 or less than 100")]
        public String Name { get; set; }
        /// <summary>
        /// email
        /// </summary>
        /// <example>sample@email.com</example>
        [Required(ErrorMessage = "email required")]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "not valid email")]
        public String Email { get; set; }
        /// <summary>
        /// password
        /// </summary>
        /// <example>password1</example>
        [Required(ErrorMessage = "password required")]
        [RegularExpression(@"^(?=.*\d).{8,}$", ErrorMessage = "password must have 8 length and one digit")]
        public String Password { get; set; }

    }
}
