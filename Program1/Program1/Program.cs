using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class Program
    {
        static void Main(string[] args)
        
            {
                Dictionary<int, string> menuItems = new Dictionary<int, string>()
        {
            {1, "Coffee"},
            {2, "Grilled Sandwich"},
            {3, "French Fries"},
            {4, "Noodles"},
            {5, "Pizza"}
        };

                Dictionary<string, int> order = new Dictionary<string, int>();

                while (true)
                {
                    Console.WriteLine("Menu:");
                    foreach (var item in menuItems)
                    {
                        Console.WriteLine($"{item.Key}. {item.Value}");
                    }

                    Console.Write("Select the item from the menu you want to order: ");
                    int selectedItem = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Quantity: ");
                    int quantity = Convert.ToInt32(Console.ReadLine());

                    string selectedItemName = menuItems[selectedItem];
                    if (order.ContainsKey(selectedItemName))
                    {
                        order[selectedItemName] += quantity;
                    }
                    else
                    {
                        order[selectedItemName] = quantity;
                    }

                    Console.Write("Do you want to add more items? (Y/N): ");
                    string addMore = Console.ReadLine().ToUpper();
                    if (addMore != "Y")
                    {
                        break;
                    }
                }

                int totalItems = 0;
                Console.WriteLine("Items in your order:");
                foreach (var item in order)
                {
                    Console.WriteLine($"{item.Value} {item.Key}");
                    totalItems += item.Value;
                }

                Console.WriteLine($"Total Items: {totalItems}");
            }
        }
    }
    }
}
