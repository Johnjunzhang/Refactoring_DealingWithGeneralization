namespace DealingWithGeneralization.ExtractSubclass
{
    public class Employee
    {
        public Employee(int rate)
        {
            Rate = rate;
        }

        public int Rate { get; private set; }
    }
}