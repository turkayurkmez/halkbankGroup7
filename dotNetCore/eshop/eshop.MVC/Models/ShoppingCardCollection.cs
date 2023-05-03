using eshop.Entities;

namespace eshop.MVC.Models
{
    public class ShoppingCardItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
    public class ShoppingCardCollection
    {
        public List<ShoppingCardItem> Products { get; set; } = new List<ShoppingCardItem>();

        public void AddProduct(ShoppingCardItem product)
        {
            var existingProduct = Products.FirstOrDefault(p => p.Product.Id == product.Product.Id);
            if (existingProduct != null)
            {
                existingProduct.Quantity += product.Quantity;
            }
            else
            {
                Products.Add(product);
            }
        }

        public void Clear() => Products.Clear();
        public decimal GetTotalPrice() => Products.Sum(p => (p.Product.Price * (decimal)(1 - p.Product.DiscountRate)) * p.Quantity);
        public int TotalItemsQuantity() => Products.Sum(x => x.Quantity);



    }
}
