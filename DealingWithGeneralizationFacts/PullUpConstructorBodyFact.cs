using DealingWithGeneralization.PullUpConstructorBody;
using Xunit;

namespace DealingWithGeneralizationFacts
{
    public class PullUpConstructorBodyFact
    {
        [Fact]
        public void should_not_assign_car_given_manager_grade_is_less_than_five()
        {
            var manager = new Manager("", "", 4);
            Assert.False(manager.IsCarAssigned);
        }

        [Fact]
        public void should_assign_car_given_manager_grade_is_greater_than_four()
        {
            var manager = new Manager("", "", 5);
            Assert.True(manager.IsCarAssigned);
        }

        [Fact]
        public void should_not_assign_car_given_is_sales_man()
        {
            var manager = new Salesman("", "");
            Assert.False(manager.IsCarAssigned);
        }
    }
}