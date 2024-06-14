using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, address1, address2, city, email, state, gender;
            int age;
            long phoneNumber;
            Console.WriteLine("Kindly provide the student details:");
            Console.Write("1. FirstName: ");
            firstName = Console.ReadLine();
            Console.Write("2. LastName: ");
            lastName = Console.ReadLine();
            Console.WriteLine("3. Age (int): ");
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.Write("4. Address 1: ");
                address1 = Console.ReadLine();
                Console.WriteLine("5. Address 2: ");
                address2 = Console.ReadLine();
                Console.Write("6. city: ");
                city = Console.ReadLine();
                Console.WriteLine("7. State: ");
                state = Console.ReadLine();
                Console.WriteLine("8. Email Id: ");
                email = Console.ReadLine();
                Console.WriteLine("9. phone Number (int): ");
                while (!long.TryParse(Console.ReadLine(), out phoneNumber))
                {
                    {
                        Console.WriteLine("please enter a valid integer for phone Number.");
                        Console.Write("9. phone Number (int): ");

                        Console.WriteLine("10. Gender:");
                        gender = Console.ReadLine();

                        Console.WriteLine("\nStudent Details Entered by you is:");
                        Console.WriteLine($"FirstName: {firstName}");
                        Console.WriteLine($"LastName:  {lastName}");
                        Console.WriteLine($"Age:       {age}");
                        Console.WriteLine($"Address 1: {address1}");
                        Console.WriteLine($"Address 2: {address2}");
                        Console.WriteLine($"City:      {city}");
                        Console.WriteLine($"State:     {state}");
                        Console.WriteLine($"Email Id:  {email}");
                        Console.WriteLine($"Phone Number:  {phoneNumber}");
                        Console.WriteLine($"Gender:  {gender}");
                    }
                }
            }
        }
    }
}



























