
namespace Money.DTOs
{
    using Microsoft.AspNetCore.Mvc.ModelBinding;

    /// <summary>
    /// Validation Error.
    /// </summary>
    public class ValidationErrorDTO
    {
        /// <summary>
        /// Gets or sets message.
        /// </summary>
        /// <example>Validation Error.</example>
        required public string Message { get; set; }

        /// <summary>
        /// Gets or sets error.
        /// </summary>
        /// <example>
        /// { "key1": ["erro1", "erro2"], "key2": ["erro3", "erro4"] }
        /// </example>
        required public Dictionary<string, string[]> Error { get; set; }

        public static ValidationErrorDTO Gen(ModelStateDictionary model) => new ()
        {
            Message = "Validation Error",
            Error = model.ToDictionary(
                    kvp => kvp.Key,
                    kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray()
                ),
        };
    }
}
