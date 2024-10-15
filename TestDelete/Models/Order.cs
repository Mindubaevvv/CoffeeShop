namespace TestDelete.Models
{
    public class Order
    {
        public int Id { get; set; }
        public required string Type { get; set; }

        public required string Cup { get; set; }

        public required string Sugar { get; set; }

        public required string Pay { get; set; }

        public decimal Price { get; set; }
    }
}
