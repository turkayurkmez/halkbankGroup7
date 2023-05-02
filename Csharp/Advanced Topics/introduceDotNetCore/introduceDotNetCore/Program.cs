var builder = WebApplication.CreateBuilder(args);

//---1. Önce builder'in ihtiyaç duyduğu malzemeleri Services koleksiyonuna ekleyin:
builder.Services.AddControllersWithViews();


var app = builder.Build();

/*
 * Middleware: Bir httpRequest işlenmeye başlamadan önce işlemin gerçekleştiği her bir adım bir middleware'dir.
 *  Metafor: Soda dolum tesisi:
 *   1. Şişelere etiket bas
 *   2. Şişeleri doldur
 *   3. Şişeleri kapat
 *   4. Şişeleri kolile
 *   
 *   Gerçek:
 *   1. Bak bakalım http isteği nasıl tarayıcıdan geliyor? ->Middleware
 *   2. Eğer tarayıcı IE türündeyse -> Middleware
 *   3. 400 Hatası ver ve tarayıcının yeterli olmadığı Response'unu döndür. ->Middleware
 *   
 *   Pipeline: Middleware çalışma sırası...
 *   
 *   
 */
//Kim hangi adrese request gönderirse göndersin; aynı sayfaya yönlendir:
//1. Gelen http request'i yakala
//2. Belirtilen .html sayfasına yönlendir

//---2. Middleware'i doğru çalışma sırası ile (pipeline) app'e ekleyin. 
//app.UseWelcomePage();

//1. Controller'ın action'una git
//2. Sayfada gösterilecek veriyi hazırla (Model)
//3. View'i oluştur
app.UseStaticFiles();

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
