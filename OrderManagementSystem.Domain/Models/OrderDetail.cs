using System.ComponentModel.DataAnnotations;

namespace OrderManagementSystem.Domain.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderID { get; set; } // Composite Primary Key, Foreign Key
        public int ProductID { get; set; } // Composite Primary Key, Foreign Key

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        // Navigation Properties
        public Order Order { get; set; }
        public Product Product { get; set; }
    }

}
