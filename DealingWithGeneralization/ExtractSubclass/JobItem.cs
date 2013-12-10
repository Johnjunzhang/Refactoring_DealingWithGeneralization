namespace DealingWithGeneralization.ExtractSubclass
{
    public class JobItem
    {
        private readonly int unitPrice;
        private readonly bool isLabor;

        public JobItem(int unitPrice, int quantity, bool isLabor, Employee employee)
        {
            this.unitPrice = unitPrice;
            Quantity = quantity;
            this.isLabor = isLabor;
            Employee = employee;
        }

        public int GetTotalPrice()
        {
            return GetUnitPrice()*Quantity;
        }

        private int GetUnitPrice()
        {
            return isLabor ? Employee.Rate : unitPrice;
        }

        public int Quantity { get; private set; }
        public Employee Employee { get; private set; }
    }
}