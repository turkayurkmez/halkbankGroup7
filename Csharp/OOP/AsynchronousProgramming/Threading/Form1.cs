namespace Threading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        Thread thread;
        private void buttonForLoop_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(counter));
            thread.Start();
            thread.Join();
            MessageBox.Show("İşlem bitti");
        }


        void counter()
        {

            for (int i = 0; i < 10000; i++)
            {
                labelResult.Text = i.ToString();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("yap");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}