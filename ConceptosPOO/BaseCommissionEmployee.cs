namespace ConceptosPOO
{
    public class BaseCommissionEmployee : CommissionEmployee
    {
        public decimal BaseSalary { get; set; }
        public override decimal GetValueToPay()
        {
            return BaseSalary + base.GetValueToPay();
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tBase salary..........: {$"{BaseSalary:C2}",18}";
        }
    }
}
