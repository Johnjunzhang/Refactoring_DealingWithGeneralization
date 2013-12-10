using DealingWithGeneralization.ExtractSubclass;
using Xunit;

namespace DealingWithGeneralizationFacts
{
    public class ExtractSubclassFact
    {
        [Fact]
        public void should_get_total_price_given_is_labor()
        {
            var jobItem = new JobItem(10, 2, true, new Employee(20));
            Assert.Equal(40, jobItem.GetTotalPrice());
        }

        [Fact]
        public void should_get_total_price_given_is_not_labor()
        {
            var jobItem = new JobItem(10, 2, false, new Employee(20));
            Assert.Equal(20, jobItem.GetTotalPrice());
        }
    }
}
