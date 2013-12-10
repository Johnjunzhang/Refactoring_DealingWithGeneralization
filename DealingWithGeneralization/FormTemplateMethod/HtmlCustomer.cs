using System.Collections.Generic;

namespace DealingWithGeneralization.FormTemplateMethod
{
    public class HtmlCustomer
    {
        private readonly string name;
        private readonly List<Rental> rentals = new List<Rental>();
        public HtmlCustomer(string name)
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
            var result = "<H1>Rentals for <EM>" + name + "</EM></H1><P>\n";

            foreach (var each in rentals)
            {
                // show figures for the rental
                result += ": " + each.GetCharge() + "<BR>\n";
                totalAmount += each.GetCharge();
            }

            // add footer lines
            result += "<P>You owe <EM>" + totalAmount + "</EM><P>\n";
            return result;
        }
    }
}