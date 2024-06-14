using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccessModifiersExample
    {
        // Public class can be accessed from anywhere
        public class PublicClass
        {
            // Public member can be accessed from anywhere
            public string PublicProperty { get; set; }

            // Private member can only be accessed within the class
            private string PrivateProperty { get; set; }

            // Protected member can be accessed within the class and by derived class instances
            protected string ProtectedProperty { get; set; }

            // Internal member can be accessed within the same assembly
            internal string InternalProperty { get; set; }

            // Protected Internal member can be accessed within the same assembly 
            // or by derived class instances
            protected internal string ProtectedInternalProperty { get; set; }

            // Private Protected member can be accessed within the same class or in derived classes 
            // that are in the same assembly
            private protected string PrivateProtectedProperty { get; set; }

            // Method to demonstrate access levels within the class
            public void ShowAccessLevels()
            {
                PublicProperty = "Public";
                PrivateProperty = "Private";
                ProtectedProperty = "Protected";
                InternalProperty = "Internal";
                ProtectedInternalProperty = "Protected Internal";
                PrivateProtectedProperty = "Private Protected";

                Console.WriteLine($"PublicProperty: {PublicProperty}");
                Console.WriteLine($"PrivateProperty: {PrivateProperty}");
                Console.WriteLine($"ProtectedProperty: {ProtectedProperty}");
                Console.WriteLine($"InternalProperty: {InternalProperty}");
                Console.WriteLine($"ProtectedInternalProperty: {ProtectedInternalProperty}");
                Console.WriteLine($"PrivateProtectedProperty: {PrivateProtectedProperty}");
            }
        }

        // Derived class to demonstrate access levels
        public class DerivedClass : PublicClass
        {
            public void ShowDerivedClassAccessLevels()
            {
                PublicProperty = "Public from Derived";
                // PrivateProperty = "Private"; // Not accessible
                ProtectedProperty = "Protected from Derived";
                InternalProperty = "Internal from Derived";
                ProtectedInternalProperty = "Protected Internal from Derived";
                // PrivateProtectedProperty = "Private Protected"; // Accessible only if in the same assembly

                Console.WriteLine($"PublicProperty: {PublicProperty}");
                Console.WriteLine($"ProtectedProperty: {ProtectedProperty}");
                Console.WriteLine($"InternalProperty: {InternalProperty}");
                Console.WriteLine($"ProtectedInternalProperty: {ProtectedInternalProperty}");
                // Console.WriteLine($"PrivateProtectedProperty: {PrivateProtectedProperty}"); // Not accessible
            }
        }

        class Program
        {
            static void main(string[] args)
            {
                PublicClass publicClassInstance = new PublicClass();
                publicClassInstance.ShowAccessLevels();

                DerivedClass derivedClassInstance = new DerivedClass();
                derivedClassInstance.ShowDerivedClassAccessLevels();
            }
        }
    }


