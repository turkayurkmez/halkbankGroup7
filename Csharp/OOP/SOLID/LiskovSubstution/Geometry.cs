namespace LiskovSubstution
{

    /*
 *  Liskov diyor ki; Bir X sınıfı, Y sınıfından miras almış ise; X ile Y birbirlerinin yerine kullanılabilir olmalıdır.
 *   İster parametre olarak
 *   İster dönen değer olarak
 *   
 *   Başka bir deyiş ile;
 *   X sınıfı Y'den aldığı özelliklerin DAVRANIŞINI DEĞİŞTİRMEMELİ
 *   
 *   Eğer Miras alan (derived) miras verenden (base) farklı davranıyorsa ihlal ediyorsun demektir.
 
 */
    public interface IAreaCalcutable
    {
        int GetArea();
    }
    public class RectangleFactory
    {
        public static IAreaCalcutable CreateRectangle(int unit1, int? unit2 = null)
        {
            //Burada bir biçimde kare döndürmeniz gerektiğini var sayın.
            if (unit2 == null)
            {
                return new Square() { EdgeLength = unit1 };
            }

            return new Rectangle() { Width = unit1, Height = unit2.Value };

        }
    }
    public class Rectangle : IAreaCalcutable
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int GetArea()
        {
            return Width * Height;
        }


    }

    public class Square : IAreaCalcutable
    {
        public int EdgeLength { get; set; }

        public int GetArea()
        {
            return EdgeLength * EdgeLength;
        }
    }


}
