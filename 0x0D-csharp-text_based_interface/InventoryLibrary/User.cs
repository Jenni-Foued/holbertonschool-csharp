namespace InventoryLibrary
{
    /// <summary>
    /// User class derived from BaseClass.
    /// </summary>
    public class User : BaseClass
    {
        /// <summary>
        /// User's name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// User class constructor.
        /// </summary>
        /// <param name="name">User's name</param>
        public User(string name)
        {
            this.name = name;
        }
    }
}
