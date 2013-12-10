namespace DealingWithGeneralization.PushDownField
{
    public class Salesman : Employee
    {
        public Salesman(double salesmanQuotaQuota)
        {
            SalesmanQuota = salesmanQuotaQuota;
        }

        public double GetSalesmanQuota()
        {
            return SalesmanQuota;
        }
    }
}