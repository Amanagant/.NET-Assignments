using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MenuProgram
{
     public class Employee
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public decimal BaseSalary { get; set; }
        public Employee(string name, string title, string gender, int age, decimal baseSalary)
        {
            Name = name;
            Title = title;
            Gender = gender;
            Age = age;
            BaseSalary = baseSalary;
        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Title: {Title}, Gender: {Gender}, Age: {Age}, Base Salary: {BaseSalary}");
        }
    }
    public class Manager : Employee
    {
        public Manager(string name, string title, string gender, int age, decimal baseSalary) : base(name, title, gender, age, baseSalary)
        {
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            decimal bonus = BaseSalary * 0.1m;
            Console.WriteLine($"Bonus: {bonus}");
        }
    }
    public class DeliveryPartner : Employee
    {
        public DeliveryPartner(string name, string title, string gender, int age, decimal baseSalary) : base(name, title, gender, age, baseSalary)
        {
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            decimal bonus = BaseSalary * 0.1m;
            Console.WriteLine("Bonus; {bonus}");
        }
    }









    class Program
    {
        static void main(string[] args)
        {
            Manager manager = new Manager("john", "Manager", "Male", 35, 50000);
            manager.DisplayDetails();
            DeliveryPartner deliveryPartner = new DeliveryPartner("Alice", "Delivery Partner", "Female", 28, 30000);
            deliveryPartner.DisplayDetails();

        }
    }
}
    
        
    
        
    

    

