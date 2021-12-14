using InventoryLibrary;
using System;
using System.Text;

namespace InventoryManager
{
    class InventoryManager
    {
        static void Main(string[] args)
        {
            StringBuilder prompt = new StringBuilder("Inventory Manager");
            prompt.Append("\n-------------------------");
            prompt.Append("\n<ClassNames> show all ClassNames of objects");
            prompt.Append("\n<All> show all objects");
            prompt.Append("\n<All [ClassName]> show all objects of a ClassName");
            prompt.Append("\n<Create [ClassName]> a new object");
            prompt.Append("\n<Show [ClassName object_id]> an object");
            prompt.Append("\n<Update [ClassName object_id]> an object");
            prompt.Append("\n<Delete [ClassName object_id]> an object");
            prompt.Append("\n<Exit>");
            Console.WriteLine(prompt);
        }
    }
}
