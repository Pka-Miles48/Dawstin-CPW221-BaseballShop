namespace Dawstin_CPW221_BaseballShop.Models
{
    /// <summary>
    /// Represents an event in the Baseball Shop system.
    /// </summary>
    public class Event
    {
        /// <summary>
        /// Gets or sets the unique identifier for the event.
        /// </summary>
        public int EventID { get; set; }

        /// <summary>
        /// Gets or sets the name of the event.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the event.
        /// Provides details about what the event entails.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the scheduled date of the event.
        /// </summary>
        public DateTime EventDate { get; set; }
    }
}
