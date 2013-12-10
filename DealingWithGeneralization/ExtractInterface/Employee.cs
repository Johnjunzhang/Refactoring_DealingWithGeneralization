namespace DealingWithGeneralization.ExtractInterface
{
    public class Employee
    {
        private readonly int rate;
        private readonly bool specialSkill;

        public Employee(int rate, bool specialSkill)
        {
            this.rate = rate;
            this.specialSkill = specialSkill;
        }

        public int GetRate()
        {
            return rate;
        }

        public bool HasSpecialSkill()
        {
            return specialSkill;
        }
    }
}