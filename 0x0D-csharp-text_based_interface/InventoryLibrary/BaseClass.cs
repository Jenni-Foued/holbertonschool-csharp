using System;

namespace InventoryLibrary
{
    /// <summary>
    /// BaseClass
    /// </summary>
    public class BaseClass
    {
        /// <summary>
        /// Data's id.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Data creation date.
        /// </summary>
        public DateTime date_created { get; set; }

        /// <summary>
        /// Data update date.
        /// </summary>
        public DateTime date_updated { get; set; }
    }
}
