using DealingWithGeneralization.PushDownField;
using Xunit;

namespace DealingWithGeneralizationFacts
{
    public class PushDownFieldFact
    {
        [Fact]
        public void should_get_sales_man_quota()
        {
            var salesman = new Salesman(100);
            Assert.Equal(100, salesman.GetSalesmanQuota());
        }
    }
}