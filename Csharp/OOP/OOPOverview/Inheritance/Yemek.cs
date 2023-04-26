namespace Inheritance
{
    public class Yemek
    {
        public List<string> Malzemeler { get; set; }
        public int PismeSuresi { get; set; }
        public double Fiyat { get; set; }

        public void Pisir()
        {
            Console.WriteLine($" {this.GetType().Name} türündeki yemek {PismeSuresi} dakikada pişti");
        }
        public virtual void SunumYap()
        {
            Console.WriteLine($"{this.GetType().Name} türündeki yemek, yanında pilav sunuldu");
        }
    }

    /* --Yemek
     *  -- Çorba
     *     -- Sebze Çorbası
     *  -- Sebze Yemeği
     *     -- Zeytinyağlı
     *     -- Tereyağlı mı
     *  -- Et Yemeği
     *     -- Kırmızı 
     *     -- Tavuk
     */

    public class Corba : Yemek
    {
        public bool BaharatOlsunMu { get; set; }
        public bool SogukIcilebilirMi { get; set; }

    }

    public class DomatesCorbasi : Corba
    {
        public int KasarMiktari { get; set; }
    }

    public class SebzeYemegi : Yemek
    {
        public bool SuyuVarMi { get; set; }
    }

    public class Pirasa : SebzeYemegi
    {
        public int LimonOrani { get; set; }
    }

    public class Tulumba : Yemek
    {
        public override void SunumYap()
        {
            Console.WriteLine($"{this.GetType().Name} türündeki tatlı, yanında su ile sunuldu");
        }
    }

}

