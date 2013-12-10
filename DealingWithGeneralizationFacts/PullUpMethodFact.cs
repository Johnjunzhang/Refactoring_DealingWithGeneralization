using System;
using DealingwithGeneralization.PullUpMethod;
using Xunit;

namespace DealingWithGeneralizationFacts
{
    public class PullUpMethodFact
    {
        [Fact]
        public void should_get_bill_for_regular_customer()
        {
            var regularCustomer = new RegularCustomer();
            regularCustomer.CreateBill(DateTime.Now);
            Assert.Equal(100, regularCustomer.GetBill());
        }

        [Fact]
        public void should_get_bill_for_preferred_customer()
        {
            var preferredCustomer = new PreferredCustomer();
            preferredCustomer.CreateBill(DateTime.Now);
            Assert.Equal(200, preferredCustomer.GetBill());
        }
    }
}