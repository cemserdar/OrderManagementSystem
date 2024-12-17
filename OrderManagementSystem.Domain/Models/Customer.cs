namespace OrderManagementSystem.Domain.Models
{
    public class Customer
    {
        public string CustomerID { get; set; } // Primary Key
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }

        // Navigation Property: Müşterinin birden fazla siparişi olabilir
        public ICollection<Order> Orders { get; set; }
    }

}
