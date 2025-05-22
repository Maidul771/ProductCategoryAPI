namespace ProductCategoryAPI.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation
        public ICollection<Product>? Products { get; set; }
    }

}
