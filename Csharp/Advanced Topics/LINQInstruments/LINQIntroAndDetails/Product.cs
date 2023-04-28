namespace LINQIntroAndDetails
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }
        public string Color { get; set; }

        public Category Category { get; set; }

    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ProductService
    {
        List<Product> products;
        List<Category> categories;
        public ProductService()
        {
            Category ustGiyim = new Category { Id = 1, Name = "Üst Giyim" };
            Category altGiyim = new Category { Id = 2, Name = "Alt Giyim" };
            Category aksesuar = new Category { Id = 3, Name = "Aksesuar" };


            categories = new List<Category>()
            {
               ustGiyim, altGiyim, aksesuar
            };

            products = new()
            {
                new(){ Id = 1, Name="Tişört", Color="Kırmızı", Description="Basic Tişört", Price=75, Rating=4.4, Category =ustGiyim},
                new(){ Id = 2, Name="Şapka", Color="Beyaz", Description="Şapka", Price=100, Rating=4.1, Category=aksesuar},
                new(){ Id = 3, Name="Kanvas", Color="Mavi", Description="Kanvas", Price=175, Rating=4.6, Category = altGiyim},
                new(){ Id = 4, Name="Şort", Color="Kırmızı", Description="Açıklama", Price=275, Rating=3.9, Category =altGiyim},
                new(){ Id = 5, Name="Etek", Color="Kırmızı", Description="Açıklama", Price=175, Rating=4.9, Category=altGiyim},
                new(){ Id = 6, Name="Tayt", Color="Mavi", Description="Açıklama", Price=150, Rating=4.1, Category=altGiyim},
                new(){ Id = 7, Name="Kot Pantolon", Color="Beyaz", Description="Açıklama", Price=250, Rating=4.4, Category = altGiyim }
        };

        }

        public List<Product> GetProducts() => products;
    }
}
