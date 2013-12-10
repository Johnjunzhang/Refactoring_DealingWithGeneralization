using System;

namespace DealingWithGeneralization.ExtractSuperclass
{
    public class Employee
    {
        public Employee(String name, String id, int annualCost)
        {
            Name = name;
            Id = id;
            AnnualCost = annualCost;
        }

        public int AnnualCost { get; private set; }
        public string Id { get; private set; }
        public string Name { get; private set; }
    }
}