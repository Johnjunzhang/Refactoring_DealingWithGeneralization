using System;

namespace DealingWithGeneralization.PullUpConstructorBody
{
    public class Employee
    {
        protected String Name;
        protected String Id;

        public bool IsCarAssigned { get; private set; }

        public virtual bool IsPriviliged()
        {
            return false;
        }
        
        protected void AssignCar()
        {
            IsCarAssigned = true;
        }
    }
}