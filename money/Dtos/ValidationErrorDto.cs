using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace money.Dto
{
    /// <summary>
    /// Validation Error
    /// </summary>
    public class ValidationErrorDto
    {
        /// <summary>
        /// Message
        /// </summary>
        /// <example>Validation Error</example>
        public string Message { get; set; }
        /// <summary>
        /// Error
        /// </summary>
        /// <example>
        /// { "key1": ["erro1", "erro2"], "key2": ["erro3", "erro4"] }
        /// </example>
        public Dictionary<string, string[]> Error { get; set; }

        public static ValidationErrorDto Gen(ModelStateDictionary model)
        {
            return new ValidationErrorDto() { 
                Message = "Validation Error",
                Error = model.ToDictionary(
                    kvp => kvp.Key,
                    kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray()
                )
            };
        }
    }
}
