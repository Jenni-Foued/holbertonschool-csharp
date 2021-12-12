namespace InventoryLibrary
{
    /// <summary>
    /// Inventory class derived from BaseClass.
    /// </summary>
    public class Inventory : BaseClass
    {
        /// <summary>
        /// User's id.
        /// </summary>
        public string user_id { get; set; }

        /// <summary>
        /// Item's id.
        /// </summary>
        public string item_id { get; set; }

        /// <summary>
        /// Quantity of items in the inventory.
        /// </summary>
        public int quantity { get; set; }

        /// <summary>
        /// Inventory class constructor.
        /// </summary>
        /// <param name="user_id">User's id</param>
        /// <param name="item_id">Item's id</param>
        /// <param name="quantity">Item's quantity</param>
        public Inventory(string user_id, string item_id, int quantity = 1)
        {
            this.user_id = user_id;
            this.item_id = item_id;
            this.quantity = quantity;
        }
    }
}
