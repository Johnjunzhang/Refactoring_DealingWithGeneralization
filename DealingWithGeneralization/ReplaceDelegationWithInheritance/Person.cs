using System;

namespace DealingWithGeneralization.ReplaceDelegationWithInheritance
{
    class Person
    {
        String name;

        public String GetName()
        {
            return name;
        }
        public void SetName(String arg)
        {
            name = arg;
        }
        public String GetLastName()
        {
            return name.Substring(name.LastIndexOf(' ') + 1);
        }
    }
}