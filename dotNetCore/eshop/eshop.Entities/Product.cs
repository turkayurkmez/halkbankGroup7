namespace eshop.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public double DiscountRate { get; set; }

        public string ImageUrl { get; set; } = "https://cdn.dsmcdn.com//ty160/product/media/images/20210819/16/120151286/123408601/5/5_org.jpg";


    }
}