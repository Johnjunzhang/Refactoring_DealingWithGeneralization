using System;

namespace DealingWithGeneralization.ReplaceDelegationWithInheritance
{
    public class Employee
    {
        readonly Person person = new Person();

        public String GetName()
        {
            return person.GetName();
        }

        public void SetName(String arg)
        {
            person.SetName(arg);
        }

        public String Statement()
        {
            return "Emp: " + person.GetLastName();
        }
    }
}