namespace OrderManagementSystem.Domain.Models
{
    public class Order
    {
        public int OrderID { get; set; } // Primary Key
        public string CustomerID { get; set; } // Foreign Key
        public DateTime OrderDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public decimal Freight { get; set; }

        // Navigation Properties
        public Customer Customer { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
        
    }

}
