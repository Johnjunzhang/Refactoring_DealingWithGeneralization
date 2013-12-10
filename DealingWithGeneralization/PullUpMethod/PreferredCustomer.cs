using System;

namespace DealingwithGeneralization.PullUpMethod
{
    public class PreferredCustomer : Customer
    {
        public void CreateBill(DateTime date)
        {
            var chargeAmount = ChargeFor(LastBillDate, date);
            AddBill(date, chargeAmount);
        }

        public double ChargeFor(DateTime startDate, DateTime endDate)
        {
            return 200;
        }
    }
}