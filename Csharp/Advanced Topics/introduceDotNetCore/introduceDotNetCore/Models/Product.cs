using System.ComponentModel.DataAnnotations;

namespace introduceDotNetCore.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad alanını doldurunuz")]
        [MinLength(3, ErrorMessage = "En az üç harften oluşmalıdır")]
        public string Name { get; set; }
        public string Description { get; set; }
        public double? Price { get; set; }
        public DateTime ProductionDate { get; set; }
    }
}
