using System;

namespace DPM225412_HuynhTruongPhatDat_Real10_Facade
{
    /// <summary>
    /// Facade Design Pattern - Real World Example
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Facade
            Mortgage mortgage = new Mortgage();

            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\n" + customer.Name +
                    " has been " + (eligible ? "Approved" : "Rejected"));

            // Wait for user
            Console.ReadKey();
        }
    }
}
