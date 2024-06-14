using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    

public class AddMenu
    {
        static string[] menuItems = { "Coffee", "Grilled Sandwich", "French Fries", "Noodles", "Pizza" };
        static int[] itemArray = { 1, 2, 3, 4, 5 };
        static int[] priceOfItem = { 50, 60, 100, 50, 30 };

        static Dictionary<int, int> purchase = new Dictionary<int, int>();

        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("1. Show Menu");
                Console.WriteLine("2. Purchase Item and Quantity");
                Console.WriteLine("3. Calculate Bill");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ShowMenu();
                        break;
                    case 2:
                        PurchaseItemAndQuantity();
                        break;
                    case 3:
                        CalculateBill();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("Menu:");
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine($"{itemArray[i]}. {menuItems[i]} - {priceOfItem[i]}");
            }
        }

        static void PurchaseItemAndQuantity()
        {
            Console.Write("Enter item number to purchase: ");
            int itemNumber = int.Parse(Console.ReadLine());

            if (Array.Exists(itemArray, element => element == itemNumber))
            {
                Console.Write("Enter quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                if (purchase.ContainsKey(itemNumber))
                {
                    purchase[itemNumber] += quantity;
                }
                else
                {
                    purchase[itemNumber] = quantity;
                }

                Console.WriteLine("Item added to your purchase list.");
            }
            else
            {
                Console.WriteLine("Invalid item number.");
            }
        }

        static void CalculateBill()
        {
            int totalBill = 0;
            Console.WriteLine("Bill Details:");
            foreach (var item in purchase)
            {
                int itemIndex = Array.IndexOf(itemArray, item.Key);
                int itemPrice = priceOfItem[itemIndex];
                int quantity = item.Value;
                int cost = itemPrice * quantity;
                totalBill += cost;
                Console.WriteLine($"{menuItems[itemIndex]} (x{quantity}) - {cost}");
            }
            Console.WriteLine($"Total Bill: {totalBill}");
        }
    }


