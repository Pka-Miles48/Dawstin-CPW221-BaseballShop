namespace Dawstin_CPW221_BaseballShop.Models
{
    /// <summary>
    /// Represents error details for handling application errors.
    /// </summary>
    public class ErrorViewModel
    {
        /// <summary>
        /// Gets or sets the unique request identifier for tracking errors.
        /// </summary>
        public string? RequestId { get; set; }

        /// <summary>
        /// Gets a value indicating whether the request ID is available.
        /// Returns true if the RequestId is not null or empty; otherwise, false.
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}