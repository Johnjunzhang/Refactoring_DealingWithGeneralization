using System.Collections.Generic;

namespace DealingWithGeneralization.FormTemplateMethod
{
    public class AsciiCustomer
    {
        private readonly string name;
        private readonly List<Rental> rentals = new List<Rental>();
        public AsciiCustomer(string name)
        {
            this.name = name;
        }

        public void AddRentals(Rental rental)
        {
            rentals.Add(rental);
        }

        public string Name
        {
            get { return name; }
        }

        public string Statement()
        {
            double totalAmount = 0;
            var result = "Rental Record for " + name + "\n";

            foreach (var each in rentals)
            {
                // show figures for the rental
                result += each.GetCharge() + "\n";
                totalAmount += each.GetCharge();
            }

            // add footer lines
            result += "Amount owed is " + totalAmount + "\n";
            return result;
        }
    }
}