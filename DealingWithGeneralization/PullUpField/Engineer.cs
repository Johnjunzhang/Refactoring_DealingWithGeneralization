namespace DealingwithGeneralization.PullUpField
{
    public class Engineer : Employee
    {
        private readonly string name;

        public Engineer(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return "Engineer " + name;
        }
    }
}