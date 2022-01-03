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
        public string id;
		/// <summary>
		/// Data creation date.
		/// </summary>
		public DateTime date_created;
		/// <summary>
		/// Data update date.
		/// </summary>
		public DateTime date_updated;

		/// <summary>
		/// BaseClass constructor.
		/// </summary>
		public BaseClass()
		{
			id = GenerateId();
			date_created = new DateTime();
			date_updated = new DateTime();
		}

		/// <summary>
		/// GeneratedID
		/// </summary>
		/// <returns></returns>
		public virtual string GenerateId()
		{
			Guid uuid = Guid.NewGuid();

			return uuid.ToString();
		}

		public virtual void updatetime()
		{
			date_updated = new DateTime();
		}

		public string GetAllClassAttributes()
		{
			string res = "{";
			string sep = "";
			foreach (var prop in GetType().GetProperties())
			{
				if (prop.GetValue(this, null)?.GetType() == typeof(String[]))
				{
				}
				res += String.Join("", $"{sep}{prop.Name}: {prop.GetValue(this, null)}");
				sep = ", ";
			}
			res += "}";
			return res;
		}

		public override string ToString()
		{
			return $"{{{id}: {GetAllClassAttributes()} }}";
		}
	}
}
