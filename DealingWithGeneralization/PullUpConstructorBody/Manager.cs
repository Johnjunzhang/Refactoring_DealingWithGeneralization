using System;

namespace DealingWithGeneralization.PullUpConstructorBody
{
    public class Manager : Employee
    {
        private readonly int grade;

        public Manager(String name, String id, int grade)
        {
            Name = name;
            Id = id;
            this.grade = grade;
            if (IsPriviliged()) AssignCar();
        }

        public override bool IsPriviliged()
        {
            return grade > 4;
        }
    }
}