namespace Encapsulation
{
    public class Product
    {
        private double price;

        public void SetPrice(double price)
        {
            if (price < 0)
            {
                throw new ArgumentException("Fiyat değeri negatif olamaz!");
            }
            this.price = price;
        }


        public double GetPrice()
        {
            return price;
        }

        //2001
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public string Description { get; set; } = string.Empty;

        public int Stock { get; set; }

        //read-only: sadece get bulunan property:
        public bool IsAvailableInStock { get { return Stock != 0; } }
        public string Test { set { Console.WriteLine($"{value} değeri set edildi...."); } }



    }
}
