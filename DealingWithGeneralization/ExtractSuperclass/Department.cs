using System;
using System.Collections.Generic;
using System.Linq;

namespace DealingWithGeneralization.ExtractSuperclass
{
    public class Department
    {
        private readonly List<Employee> staffs = new List<Employee>();

        public Department(String name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public int GetTotalAnnualCost()
        {
            return staffs.Sum(s => s.AnnualCost);
        }

        public int GetHeadCount()
        {
            return staffs.Count();
        }

        public void AddStaff(Employee staff)
        {
            staffs.Add(staff);
        }
    }
}