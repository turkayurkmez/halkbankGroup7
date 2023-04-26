namespace AbstractANDInterface
{
    /*
     * Doküman Yönetim Sistemi Geliştiriyoruz.....
     * Excel, Word, PDF, PowerPoint
     */
    public class Document
    {
        public string Title { get; set; }
        public string Owner { get; set; }
        public void Copy(string from, string to)
        {
            Console.WriteLine($"Doküman, {from} adresinden {to} adresine kopyalandı");
        }
    }
}
