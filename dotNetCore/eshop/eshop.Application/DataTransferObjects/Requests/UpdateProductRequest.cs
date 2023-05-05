using System.ComponentModel.DataAnnotations;

namespace eshop.Application.DataTransferObjects.Requests
{
    public class UpdateProductRequest
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ürün adını boş bırakmayınız!")]
        [MinLength(3, ErrorMessage = "En az 3 karakter içermelidir")]
        [MaxLength(150, ErrorMessage = "En fazla 150 karakter")]
        public string Name { get; set; }
        public string? Description { get; set; }
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Ürün fiyatı geçerli bir değer olmalı")]
        public decimal Price { get; set; }
        public double? DiscountRate { get; set; }

        public string? ImageUrl { get; set; } = "https://cdn.dsmcdn.com//ty160/product/media/images/20210819/16/120151286/123408601/5/5_org.jpg";

        public int? CategoryId { get; set; }
    }
}
