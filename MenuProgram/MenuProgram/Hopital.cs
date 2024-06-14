using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Hospital
    {
        internal class Petient
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Gender { get; set; }
            public int Age { get; set; }
            public string Number { get; set; }
            public string State { get; set; }
            public string Pincode { get; set; }

            public Petient()
            {
            }

            public Petient(string firstName, string lastName, string gender, int age, string number, string state, string pincode)
            {
                FirstName = firstName;
                LastName = lastName;
                Gender = gender;
                Age = age;
                Number = number;
                State = state;
                Pincode = pincode;
            }
        }

        internal class MainMethod
        {
            public enum Department
            {
                General = 400,
                ENT = 800,
                Cardiology = 1200,
                OperationTheater = 5000,
                IntensiveCareUnit = 6000
            }

            public static void main()
            {
                Console.WriteLine("Enter first name:Chandana");
                Console.WriteLine("Welcome to ABC hospital");
                Console.WriteLine("Select the department for the treatment");
                Console.WriteLine("1. General : 700");
                Console.WriteLine("2. ENT : 1000");
                Console.WriteLine("3. Cardiology : 1500");
                Console.WriteLine("4. Operation Theater : 10000");
                Console.WriteLine("5. Intensive Care Unit : 15000");

                int x = Convert.ToInt32(Console.ReadLine());
                string selectedDepartment = string.Empty;

                switch (x)
                {
                    case 400:
                        selectedDepartment = nameof(Department.General); break;
                    case 800:
                        selectedDepartment = nameof(Department.ENT); break;
                    case 1200:
                        selectedDepartment = nameof(Department.Cardiology); break;
                    case 5000:
                        selectedDepartment = nameof(Department.OperationTheater); break;
                    case 6000:
                        selectedDepartment = nameof(Department.IntensiveCareUnit); break;
                    default:
                        Console.WriteLine("Invalid Option");
                        return;
                }

                Console.WriteLine($"Selected Department: {selectedDepartment}");

                Console.WriteLine("Enter patient details");
                Petient[] patients = new Petient[3];
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Enter details for patient {i + 1}");
                    Console.Write("Enter first name: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Enter last name: ");
                    string lastName = Console.ReadLine();
                    Console.Write("Enter gender: ");
                    string gender = Console.ReadLine();
                    Console.Write("Enter age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter phone number: ");
                    string number = Console.ReadLine();
                    Console.Write("Enter state: ");
                    string state = Console.ReadLine();
                    Console.Write("Enter pincode: ");
                    string pincode = Console.ReadLine();

                    patients[i] = new Petient(firstName, lastName, gender, age, number, state, pincode);

                    Console.WriteLine();
                }

                Console.WriteLine("Search the patient details through contact number");
                Console.Write("Enter phone number: ");
                string contactInfo = Console.ReadLine();

                bool patientFound = false;
                foreach (var patient in patients)
                {
                    if (patient.Number == contactInfo)
                    {
                        Console.WriteLine($"First Name: {patient.FirstName}");
                        Console.WriteLine($"Last Name: {patient.LastName}");
                        Console.WriteLine($"Gender: {patient.Gender}");
                        Console.WriteLine($"Age: {patient.Age}");
                        Console.WriteLine($"Contact Information: {patient.Number}");
                        Console.WriteLine($"State: {patient.State}");
                        Console.WriteLine($"Pincode: {patient.Pincode}");
                        patientFound = true;
                        break;
                    }
                }

                if (!patientFound)
                {
                    Console.WriteLine("No patient found with the given contact number.");
                }
            }
        }
    }


