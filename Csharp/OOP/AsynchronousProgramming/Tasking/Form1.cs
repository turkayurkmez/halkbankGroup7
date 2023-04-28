﻿namespace Tasking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("yap");
        }

        private async void buttonForLoop_Click(object sender, EventArgs e)
        {
            Task.Run(counter);
            MessageBox.Show("dosyalar tarandı");
        }


        async Task counter()
        {

            for (int i = 0; i <= 10000; i++)
            {
                labelResult.Text = i.ToString();
                progressBar1.Value = i / 100;
            }

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            var stringData = await httpClient.GetStringAsync("https://swapi.dev/api/people/1");
            richTextBox1.Text = stringData;
        }

    }
}