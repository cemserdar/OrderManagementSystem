using System.ComponentModel.DataAnnotations;

namespace OrderManagementSystem.Domain.Models
{
    public class OrderDetails
    {
        public int OrderID { get; set; } 
        public int ProductID { get; set; } 

        public short Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        // Navigation Properties
        public Order Order { get; set; }
        public Product Product { get; set; }
    }

}
