namespace SemesterTwo.Models
{
    public class OrderItem
    {
        public int OrderId { get; set; }  // Foreign key to Order
        public Order Order { get; set; }  // Navigation property to Order

        public int ProductId { get; set; }  // Foreign key to Product
        public Product Product { get; set; }  // Navigation property to Product

        public int Quantity { get; set; }
        public decimal Price { get; set; }  // Price of the product at the time of purchase
    }
}
