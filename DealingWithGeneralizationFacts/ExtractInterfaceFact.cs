using DealingWithGeneralization.ExtractInterface;
using Xunit;

namespace DealingWithGeneralizationFacts
{
    public class ExtractInterfaceFact
    {
        [Fact]
        public void should_get_charge_for_timesheet_given_employee_has_special_skill()
        {
            var timesheet = new Timesheet();
            var charge = timesheet.Charge(new Employee(10, true), 2);
            Assert.Equal(21, charge);
        }

        [Fact]
        public void should_get_charge_for_timesheet_given_employee_does_not_have_special_skill()
        {
            var timesheet = new Timesheet();
            var charge = timesheet.Charge(new Employee(10, false), 2);
            Assert.Equal(20, charge);
        }
    }
}