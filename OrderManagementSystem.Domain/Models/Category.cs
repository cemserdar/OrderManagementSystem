namespace OrderManagementSystem.Domain.Models
{
    public class Category
    {
        public int CategoryID { get; set; } // Primary Key
        public string CategoryName { get; set; }
        public string Description { get; set; }

        // Navigation Property: Bir kategoride birden fazla ürün olabilir
        public ICollection<Product> Products { get; set; }
    }

}
