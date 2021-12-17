using InventoryLibrary;
using System;
using System.Text;

namespace InventoryManager
{
    class InventoryManager
    {
        public static JSONStorage storage = new JSONStorage();
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
            storage.Load();

            while (true)
            {
                Console.Write(">>>");
                string input = Console.ReadLine();
                string[] argus = input.Split(' ');
                string command = argus[0];
                switch (command)
                {
                    case "ClassNames":
                        break;
                    case "All":
                        All(argus);
                        break;
                    case "Create":
                        Create(argus);
                        break;
                    case "Show":
                        Show(argus);
                        break;
                    case "Update":
                        Update(argus);
                        break;
                    case "Delete":
                        Delete(argus);
                        break;
                    case "Exit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid command {0}.", argus[0]);
                        break;
                }
            }
        }

        public static void All(string[] arguments)
        { }

        public static void Create(string[] arguments)
        { }

        public static void Show(string[] arguments)
        { }

        public static void Update(string[] arguments)
        { }

        public static void Delete(string[] arguments)
        { }

    }
}
