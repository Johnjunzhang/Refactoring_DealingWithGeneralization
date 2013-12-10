using DealingWithGeneralization.ExtractSuperclass;
using Xunit;

namespace DealingWithGeneralizationFacts
{
    public class ExtractSuperClassFact
    {
        [Fact]
        public void should_get_name_for_department()
        {
            var department = new Department("DepartmentName");
            Assert.Equal("DepartmentName", department.Name);
        }

        [Fact]
        public void should_get_total_cost_for_department()
        {
            var department = new Department("DepartmentName");
            department.AddStaff(new Employee("Kent", "1", 10));
            department.AddStaff(new Employee("Martin", "1", 20));
            Assert.Equal(30, department.GetTotalAnnualCost());
        }

        [Fact]
        public void should_get_name_for_employee()
        {
            var employee = new Employee("Kent", "1", 10);
            Assert.Equal("Kent", employee.Name);
        }

        [Fact]
        public void should_get_total_cost_for_employee()
        {
            var employee = new Employee("Kent", "1", 10);
            Assert.Equal(10, employee.AnnualCost);
        }
    }
}