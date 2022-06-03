namespace WebApplication3.Models
{
    public class ProductsCatalog
    {
        public List<ProductModel> GetProducts { get; set; } = new();
      
    }

    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

    }
}
