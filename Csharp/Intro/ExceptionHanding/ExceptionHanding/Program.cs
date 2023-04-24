// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
try
{
    Console.WriteLine("Bölünecek sayıyı girin");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Bölen sayıyı girin:");
    int number2 = Convert.ToInt32(Console.ReadLine());
    int result = number1 / number2;
    Console.WriteLine($"{number1} sayısınının {number2} sayısına bölümünün sonucu: {result} sayısıdır");
}

catch (FormatException)
{
    Console.WriteLine("Sayılar sadece rakamlardan oluşmalıdır");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Tam sayılar 0'a bölünemez!!!");
}
catch (Exception ex)
{
    Console.WriteLine($"Genel bir hata meydana geldi. Hatanın mesajı: {ex.Message}");
}
finally
{
    //try bolğu bitmeden önce HATA OLUŞSA DA OLUŞMASA DA çalışmasını istediğiniz kod parçası finally içine yazılır.
    Console.WriteLine("Dosya kapatıldı");
}


Console.WriteLine("Byte aralığında (0...255) bir sayı girin:");
byte byte1 = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Aynı tipte bir sayı daha girin");

byte byte2 = Convert.ToByte(Console.ReadLine());

try
{
    checked
    {
        byte total = (byte)(byte1 + byte2);
        Console.WriteLine($"{byte1} ve {byte2} değerlerinin toplamı, {total} değeridir");
    }
}
catch (OverflowException)
{

    Console.WriteLine($"Girdiğiniz değerler toplamı, {byte.MaxValue} değerinden büyük ");
}
