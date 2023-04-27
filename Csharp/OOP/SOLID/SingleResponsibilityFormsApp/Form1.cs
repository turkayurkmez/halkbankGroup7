namespace SingleResponsibilityFormsApp
{
    public partial class Form1 : Form
    {
        /*
 * SRP: Tekil Sorumluluk Prensibi
 * Bir nesnenin sadece bir sorumluluğu olmalıdır.
 * Bir nesneyi oluşturan class içerisinde, değişiklik yapmak için birden fazla sebebiniz varsa; prensibi ihlal ediyorsunuz demektir.
 * 
 * 
 */
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            string name = textBoxProductName.Text;
            decimal price = Convert.ToDecimal(textBoxPrice.Text);

            ProductService productService = new ProductService();
            var affectedResult = productService.AddProduct(name, price);

            var message = affectedResult > 0 ? "Başarılı" : "Başarısız";
            MessageBox.Show(message);
        }
    }
}