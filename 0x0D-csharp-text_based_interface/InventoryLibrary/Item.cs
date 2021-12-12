using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary>
    /// Item class derived from BaseClass.
    /// </summary>
    public class Item : BaseClass
    {
        /// <summary>
        /// Item's name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Item's description.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Item's price.
        /// </summary>
        public float price { get; set; }

        /// <summary>
        /// A list of tags.
        /// </summary>
        public List<string> tags = new List<string>();

        /// <summary>
        /// Item class constructor.
        /// </summary>
        /// <param name="name">Item's name</param>
        /// <param name="description">Item's description</param>
        /// <param name="price">Item's price</param>
        public Item (string name, string description, float price)
        {
            this.name = name;
            this.description = description;
            this.price = (float)Math.Round(price, 2);
        }
    }
}
