using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace InventoryLibrary
{
    /// <summary>
    /// JSONStorage class.
    /// </summary>
    public class JSONStorage
    {
        /// <summary>
        /// Represents the JSON format in a dictionary.
        /// </summary>
        public Dictionary<string, dynamic> objects = new Dictionary<string, dynamic>();

        /// <summary>
        /// return objects dictionary
        /// </summary>
        /// <returns>objects dictionary</returns>
        public Dictionary<string, dynamic> All()
        {
            return objects;
        }

        /// <summary>
        /// Add a new key-value pair to objects.
        /// </summary>
        /// <param name="obj">Object</param>
        public void New(dynamic obj)
        {
            objects.Add($"{obj.GetType().Name}.{obj.id}", obj);
        }

        /// <summary>
        /// Serializes objects to JSON and saves to the JSON file.
        /// </summary>
        public void Save()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(objects, options);
            string fileName = "../storage/inventory_manager.json";
            File.WriteAllText(fileName, jsonString);
        }

        /// <summary>
        /// Deserializes JSON file to objects.
        /// </summary>
        public void Load()
        {
            string fileName = "../storage/inventory_manager.json";
            string jsonString = File.ReadAllText(fileName);
            objects = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(jsonString);
        }
    }
}
