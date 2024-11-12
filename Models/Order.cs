namespace SemesterTwo.Models
{
    public class Order
    {
        public int Id { get; set; }  // Primary key
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        // Foreign key to Customer
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }  // Navigation property to Customer

        // Collection of order items (products)
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
