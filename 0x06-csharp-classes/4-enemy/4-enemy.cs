
namespace Enemies
{
    /// <summary>
    /// Represents a Zombie by it's health
    /// </summary>
    public class Zombie
    {
        /// <summary> Represents the health of a Zombie.</summary>
        private int health;
        private string name = "(No name)";
        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class.</summary>
        public Zombie()
        {
            this.health = 0;
        }
        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class.</summary>
        public Zombie(int value)
        {
            if (value >= 0)
                this.health = value;
            else
                throw new System.ArgumentException("Health must be greater than or equal to 0");
        }
        /// <summary>Gets or sets the name.</summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary> Returns the value of health of the Zombie object.</summary>
        public int GetHealth()
        {
            return this.health;
        }
    }
}
