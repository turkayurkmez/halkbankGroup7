// See https://aka.ms/new-console-template for more information
using LINQIntroAndDetails;

Console.WriteLine("Hello, World!");
//Language INtegrated Query

ProductService service = new();
var products = service.GetProducts();

var result = from product in products
             where product.Description.Contains("Açıklama")
             orderby product.Id
             select new { UrunAdi = product.Name, Aciklama = product.Description };

foreach (var item in result)
{
    Console.WriteLine($"{item.UrunAdi}\t{item.Aciklama}");
}

Console.WriteLine("-------------------------------- ******************* -------------------------");
var sameResult = products.Where(p => p.Description.Contains("Açıklama"))
                         .Select(p => new { UrunAdi = p.Name, Fiyat = p.Price })
                         .OrderBy(ap => ap.UrunAdi)
                         .ToList();

sameResult.ForEach(x => Console.WriteLine($"{x.UrunAdi}\t\t{x.Fiyat}"));

Console.WriteLine("------------ 3 Id'li Ürün -----------------------");
var finding = products.FirstOrDefault(p => p.Id == 3);
Console.WriteLine($"id'si üç olan ürün: {finding?.Name}");

//Eğer koleksiyon dönerse hata versin derseniz: SingleOrDefault
//var error = products.SingleOrDefault(p => p.Price == 175);
Console.WriteLine("------------Aggregates------------");
var average = products.Average(p => p.Price);
Console.WriteLine($"Ortalama fiyat: {average}");
var lowRating = products.Count(p => p.Rating < 4.0);
Console.WriteLine($"Rating'i 4'ün altında kalan ürün sayısı: {lowRating}");
Console.WriteLine($"En pahalı ürün fiyatı: {products.Max(p => p.Price)}, En ucuz ise {products.Min(p => p.Price)}");

Console.WriteLine("------------------ Group by ----------------------");
var group = products.GroupBy(product => product.Color,
                             productItem => new { productItem.Name, productItem.Price, productItem.Rating },
                             (color, products) =>
                             new
                             {
                                 Key = color,
                                 Count = products.Count(),
                                 MinPrice = products.Min(p => p.Price),
                                 MaxPrice = products.Max(p => p.Price),
                                 AvgRating = products.Average(p => p.Rating)
                             }
                            )
                    .ToList();

Console.WriteLine("Renk     \tAdet\tEn ucuz\tEn Pahalı\tRating Ort.");
group.ForEach(p => Console.WriteLine($"{p.Key}        \t{p.Count}\t{p.MinPrice}\t{p.MaxPrice}\t{p.AvgRating}"));

Console.WriteLine("------ her iki objeden de veri almak:-------------- ");


var joined = products.Select(p => new { p.Name, CategoryName = p.Category.Name })
                     .ToList();

joined.ForEach(f => Console.WriteLine($"{f.Name}\t\t{f.CategoryName}"));



