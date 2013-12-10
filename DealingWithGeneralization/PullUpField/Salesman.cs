namespace DealingwithGeneralization.PullUpField
{
    public class Salesman : Employee
    {
        private readonly string name;

        public Salesman(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return "Salesman " + name;
        }
    }
}