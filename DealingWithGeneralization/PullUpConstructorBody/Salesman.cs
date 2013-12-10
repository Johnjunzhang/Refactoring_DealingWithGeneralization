using System;

namespace DealingWithGeneralization.PullUpConstructorBody
{
    public class Salesman : Employee
    {
        public Salesman(String name, String id)
        {
            Name = name;
            Id = id;
            if (IsPriviliged()) AssignCar();
        }
    }
}