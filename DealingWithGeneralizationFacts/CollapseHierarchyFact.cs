using DealingWithGeneralization.CollapseHierarchy;
using Xunit;

namespace DealingWithGeneralizationFacts
{
    public class CollapseHierarchyFact
    {
        [Fact]
        public void should_get_quota_for_sales_man()
        {
            var salesman = new Salesman(10);
            Assert.Equal(100, salesman.GetQuota());
        }

        [Fact]
        public void should_get_rate_for_sales_man()
        {
            var salesman = new Salesman(10);
            Assert.Equal(10, salesman.GetRate());
        }

        [Fact]
        public void should_get_quota_for_employee()
        {
            var employee = new Employee();
            Assert.Equal(100, employee.GetQuota());
        }
    }
}