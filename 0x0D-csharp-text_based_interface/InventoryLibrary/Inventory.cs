namespace InventoryLibrary
{
    /// <summary>
    /// Inventory class derived from BaseClass.
    /// </summary>
    public class Inventory : BaseClass
    {
        private string _user_id;

        /// <summary>
        /// User's id.
        /// </summary>
        public string user_id
        {
            get { return _user_id; }
            set
            {
                updatetime();
                _user_id = value;
            }
        }

        private string _item_id;

        /// <summary>
        /// Item's id.
        /// </summary>
        public string item_id
        {
            get { return _item_id; }
            set
            {
                updatetime();
                _item_id = value;
            }
        }

        private int _quantity;

        /// <summary>
        /// Quantity of items in the inventory.
        /// </summary>
        public int quantity
        {
            get { return _quantity; }
            set
            {
                updatetime();
                if (value < 0)
                    value = 0;
                _quantity = value;
            }
        }

        /// <summary>
        /// Inventory class constructor.
        /// </summary>
        /// <param name="user">User</param>
        /// <param name="item">Item</param>
        /// <param name="quantity">Item's quantity</param>
        public Inventory(User user, Item item, int quantity = 1)
        {
            this.user_id = user.id;
            this.item_id = item.id;
            this.quantity = quantity;
        }
    }
}
