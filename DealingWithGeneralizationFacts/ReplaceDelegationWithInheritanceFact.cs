using DealingWithGeneralization.ReplaceDelegationWithInheritance;
using Xunit;

namespace DealingWithGeneralizationFacts
{
    public class ReplaceDelegationWithInheritanceFact
    {
        [Fact]
        public void should_get_employee_name()
        {
            var employee = new Employee();
            employee.SetName("Kent");
            Assert.Equal("Kent", employee.GetName());
        }

        [Fact]
        public void should_get_statement_of_employee()
        {
            var employee = new Employee();
            employee.SetName("Kent Back");
            Assert.Equal("Emp: Back", employee.Statement());
        }
    }
}