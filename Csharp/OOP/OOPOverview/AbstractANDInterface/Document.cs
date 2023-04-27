namespace AbstractANDInterface
{
    /*
     * Doküman Yönetim Sistemi Geliştiriyoruz.....
     * Excel, Word, PDF, PowerPoint
     */
    public interface IPrintable
    {
        void Print();
    }
    public abstract class Document
    {
        public string Title { get; set; }
        public string Owner { get; set; }
        public void Copy(string from, string to)
        {
            Console.WriteLine($"Doküman, {from} adresinden {to} adresine kopyalandı");
        }
        public abstract void Load();
        public abstract void Save();


    }

    public class ExcelDocument : Document, IPrintable
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class WordDocument : Document, IPrintable
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class PDFDocument : Document
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }


        public override void Save()
        {
            throw new NotImplementedException();
        }
    }


    public class PrintComponent
    {
        public void Print(IPrintable printableDocument)
        {
            printableDocument.Print();
        }
    }


}
