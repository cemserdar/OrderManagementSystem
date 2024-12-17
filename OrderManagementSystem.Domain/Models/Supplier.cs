namespace OrderManagementSystem.Domain.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; } // Primary Key
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }

        // Navigation Property: Tedarikçinin birden fazla ürünü olabilir
        public ICollection<Product> Products { get; set; }
    }

}
