namespace InventoryLibrary
{
    /// <summary>
    /// User class derived from BaseClass.
    /// </summary>
    public class User : BaseClass
    {
        private string _name;
        /// <summary>
        /// User's name.
        /// </summary>
        public string name 
        {
            get { return _name; }
            set
            {
                updatetime();
                _name = value;
            }
        }

        /// <summary>
        /// User class constructor.
        /// </summary>
        /// <param name="name">User's name</param>
        public User(string name) : base()
        {
            this.name = name;
        }
    }
}
