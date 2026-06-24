using System;

namespace EmployeeComparisonApp
{
    // Employee class represents an employee object
    public class Employee
    {
        // Employee ID property
        public int Id { get; set; }

        // Employee first name property
        public string FirstName { get; set; }

        // Employee last name property
        public string LastName { get; set; }

        // Overload the == operator
        // Compares two Employee objects based on their Id
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // If both objects are null, they are equal
            if (ReferenceEquals(employee1, employee2))
                return true;

            // If one object is null and the other is not, they are not equal
            if (employee1 is null || employee2 is null)
                return false;

            // Compare the Id properties
            return employee1.Id == employee2.Id;
        }

        // Overload the != operator
        // Returns the opposite result of ==
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }

        // Override Equals method to match the behavior of ==
        public override bool Equals(object obj)
        {
            // Check if the object is an Employee
            if (obj is Employee employee)
            {
                return this.Id == employee.Id;
            }

            return false;
        }

        // Override GetHashCode because Equals was overridden
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
using System;

namespace EmployeeComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first Employee object
            Employee employee1 = new Employee()
            {
                Id = 1,
                FirstName = "Ali",
                LastName = "Al Gasat"
            };

            // Create the second Employee object
            Employee employee2 = new Employee()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Smith"
            };

            // Compare the two employees using the overloaded == operator
            bool areEqual = employee1 == employee2;

            // Display the result of the comparison
            Console.WriteLine($"employee1 == employee2: {areEqual}");

            // Compare the two employees using the overloaded != operator
            bool areNotEqual = employee1 != employee2;

            // Display the result of the comparison
            Console.WriteLine($"employee1 != employee2: {areNotEqual}");

            // Pause the console so the user can view the output
            Console.ReadLine();
        }
    }
}
employee1 == employee2: True
employee1 != employee2: False