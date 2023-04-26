namespace Constructors
{
    public class Otomobil
    {
        public int UretimYili { get; set; }
        public string Markasi { get; set; }

        public Otomobil()
        {
            UretimYili = DateTime.Now.Year;
            Markasi = "Hyundai";
        }



    }
}
