namespace DealingWithGeneralization.CollapseHierarchy
{
    public class Salesman : Employee
    {
        private readonly int rate;

        public Salesman(int rate)
        {
            this.rate = rate;
        }

        public new double GetQuota()
        {
            return 100;
        }

        public int GetRate()
        {
            return rate;
        }
    }
}