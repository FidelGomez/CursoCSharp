namespace ConceptosPOO
{
    public class HourlyEmployee : Employee
    {
        public decimal HourValue { get; set; }
        public float Hours { get; set; }
        public override decimal GetValueToPay()
        {
            return HourValue * (decimal)Hours;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tHour value...........: {$"{HourValue:C2}",18}" +
                $"\n\tHours worked.........: {$"{Hours:N2}",18}" +
                $"\n\tValue to pay.........: {$"{GetValueToPay():C2}",18}";
        }
    }
}
