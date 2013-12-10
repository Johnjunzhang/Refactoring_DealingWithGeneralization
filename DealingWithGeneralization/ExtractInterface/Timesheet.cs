namespace DealingWithGeneralization.ExtractInterface
{
    public class Timesheet
    {
        public double Charge(Employee employee, int days)
        {
            var baseCharge = employee.GetRate() * days;
            if (employee.HasSpecialSkill())
                return baseCharge * 1.05;

            return baseCharge;
        }
    }
}