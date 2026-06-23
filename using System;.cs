using System;

namespace EmployeeComparisonApp
{
    // Define the Employee class
    public class Employee
    {
        // Property to store the unique employee ID
        public int Id { get; set; }
        
        // Property to store the employee's first name
        public string FirstName { get; set; }
        
        // Property to store the employee's last name
        public string LastName { get; set; }

        // Overload the "==" operator to compare two Employee objects by their Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Handle null checks to prevent NullReferenceExceptions
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            {
                return ReferenceEquals(emp1, emp2);
            }

            // Return true if IDs match, otherwise false
            return emp1.Id == emp2.Id;
        }

        // Overload the "!=" operator (required when overloading "==")
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Return the inverse of the "==" comparison
            return !(emp1 == emp2);
        }

        // Overriding Equals() and GetHashCode() is best practice when overloading comparison operators
        public override bool Equals(object obj)
        {
            if (obj is Employee emp)
            {
                return this.Id == emp.Id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}

