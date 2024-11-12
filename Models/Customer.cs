namespace SemesterTwo.Models
{
    public class Customer
    {
        public int Id { get; set; }  // Primary key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        // Navigation property for orders placed by this customer
        public ICollection<Order> Orders { get; set; }
    }
}
