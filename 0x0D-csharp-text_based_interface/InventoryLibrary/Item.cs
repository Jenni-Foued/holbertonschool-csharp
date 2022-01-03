using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary>
    /// Item class derived from BaseClass.
    /// </summary>
    public class Item : BaseClass
    {
        private string _name;
        /// <summary>
        /// Item's name.
        /// </summary>
        public string name { 
            get { return _name; }
            set {
                updatetime();
                _name = value; 
            } 
        }

        private string _description;
        /// <summary>
        /// Item's description.
        /// </summary>
        public string description {
            get { return _description; }
            set {
                updatetime();
                _description = value;
            } 
        }

        private float _price;
        /// <summary>
        /// Item's price.
        /// </summary>
        public float price {
            get { return _price; }
            set {
                updatetime();
                _price = value;
            } 
        }

        private List<string> _tags;
        /// <summary>
        /// A list of tags.
        /// </summary>
        public List<string> tags
        {
            get { return _tags; }
            set{
                updatetime();
                _tags = value;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        public Item(string name)
        {
            this.name = name;
            tags = new List<string>();
        }
    }
}
