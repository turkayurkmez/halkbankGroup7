namespace functionOverloadingAndOptional
{
    public class Geometry
    {
        /*amaç: 
         * Kare, Üçgen, Daire ya da Dikdörtgen şekillerinden birinin alanını hesaplayan fonksiyonlar.
         * Kare -> 1 birim
         * Üçgen -> 2 birim
         * Daire -> 1 birim
         * Dikdörtgen -> 2 birim
         */
        /// <summary>
        /// Bu fonksiyon, Kare veya Daire şekillerinin alanını hesaplar.
        /// </summary>
        /// <param name="unitLength">Birim uzunluk değeri (yarı çap veya kenar uzunluğu)</param>
        /// <param name="shape">"Daire" ya da "Kare"</param>
        /// <returns></returns>
        public double GetArea(double unitLength, string shape)
        {
            double area = 0;
            switch (shape)
            {
                case "Kare":
                    area = Math.Pow(unitLength, 2);
                    break;
                case "Daire":
                    area = Math.PI * Math.Pow(unitLength, 2);
                    break;
                default:
                    break;
            }
            return area;
        }
        /// <summary>
        ///  Bu fonksiyon, Üçgen veya Dikdörtgen şekillerinin alanını hesaplar.
        /// </summary>
        /// <param name="unit1">Birim 1</param>
        /// <param name="unit2">Birim 2</param>
        /// <param name="shape">"Üçgen" ya da "Dikdörtgen"</param>
        /// <returns></returns>
        public double GetArea(double unit1, double unit2, string shape)
        {

            double area = 0;
            switch (shape)
            {
                case "Üçgen":
                    area = (unit1 * unit2) / 2;
                    break;
                case "Dikdörtgen":
                    area = unit1 * unit2;
                    break;
                default:
                    break;
            }
            return area;
        }


        public double OptionalGetArea(double unit1, double unit2 = 1, string shape = "Kare")
        {
            double area = 0;
            switch (shape)
            {
                case "Kare":
                    area = Math.Pow(unit1, 2);
                    break;
                case "Daire":
                    area = Math.PI * Math.Pow(unit1, 2);
                    break;
                case "Üçgen":
                    area = (unit1 * unit2) / 2;
                    break;
                case "Dikdörtgen":
                    area = unit1 * unit2;
                    break;
                default:
                    break;
            }
            return area;
        }


    }
}
