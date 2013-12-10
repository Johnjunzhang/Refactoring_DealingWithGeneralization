using System;

namespace DealingwithGeneralization.PullUpMethod
{
    public abstract class Customer
    {
        protected DateTime LastBillDate;
        private double bill;

        public double GetBill()
        {
            return bill;
        }

        public void AddBill(DateTime date, Double amount)
        {
            bill = amount;
        }
    }
}