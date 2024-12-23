using System.ComponentModel.DataAnnotations;

namespace money.Dtos
{
    /// <summary>
    /// User Response Dto
    /// </summary>
    public class UserResponseDto
    {
        /// <summary>
        /// name
        /// </summary>
        /// <example>Nícolas Krüger</example>
        public String Name { get; set; }
        /// <summary>
        /// email
        /// </summary>
        /// <example>sample@email.com</example>
        public String Email { get; set; }
     
        /// <summary>
        /// id
        /// </summary>
        /// <example>id_hash_123</example>
        public String Id { get; set; }
    }
}
