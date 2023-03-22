namespace ConceptosPOO
{
    public class Invoice : IPay
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public float Quantity { get; set; }
        public decimal Price { get; set; }

        public decimal GetValueToPay()
        {
            return (decimal)Quantity * Price;
        }

        public override string ToString()
        {
            return $"{ID} - {Description}" +
                $"\n\tQuantity.........: {$"{Quantity:N2}",18}" +
                $"\n\tPrice............: {$"{Price:C2}",18}" +
                $"\n\tValue............: {$"{GetValueToPay():C2}",18}";
        }
    }
}
