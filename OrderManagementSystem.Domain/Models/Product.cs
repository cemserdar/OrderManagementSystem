namespace OrderManagementSystem.Domain.Models
{
    public class Product
    {
        public int ProductID { get; set; } // Primary Key
        public string ProductName { get; set; }
        public int? SupplierID { get; set; } // Foreign Key
        public int? CategoryID { get; set; } // Foreign Key
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }

        // Navigation Properties
        public Supplier Supplier { get; set; }
        public Category Category { get; set; }
    }

}
