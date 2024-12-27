// Ignore Spelling: Dto Dtos

namespace Money.DTOs
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// User Response Dto.
    /// </summary>
    public class UserResponseDTO
    {
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        /// <example>Nícolas Krüger</example>
        required public string Name { get; set; }

        /// <summary>
        /// Gets or sets email.
        /// </summary>
        /// <example>sample@email.com</example>
        required public string Email { get; set; }

        /// <summary>
        /// Gets or sets id.
        /// </summary>
        /// <example>id_hash_123</example>
        required public string Id { get; set; }
    }
}
