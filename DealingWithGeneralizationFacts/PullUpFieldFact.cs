using DealingwithGeneralization.PullUpField;
using Xunit;

namespace DealingWithGeneralizationFacts
{
    public class PullUpFieldFact
    {
        [Fact]
        public void should_get_engineer_name()
        {
            var engineer = new Engineer("Kent");
            Assert.Equal("Engineer Kent", engineer.GetName());
        }

        [Fact]
        public void should_get_sales_man_name()
        {
            var engineer = new Salesman("Martin");
            Assert.Equal("Salesman Martin", engineer.GetName());
        }
    }
}
