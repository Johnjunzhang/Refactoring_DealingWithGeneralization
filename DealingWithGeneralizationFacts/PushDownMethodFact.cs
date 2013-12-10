using DealingWithGeneralization.PushDownMethod;
using Xunit;

namespace DealingWithGeneralizationFacts
{
    public class PushDownMethodFact
    {
        [Fact]
        public void should_get_salesman_quota()
        {
            var salesman = new Salesman();
            Assert.Equal(100, salesman.GetSalesmanQuota());
        }
    }
}