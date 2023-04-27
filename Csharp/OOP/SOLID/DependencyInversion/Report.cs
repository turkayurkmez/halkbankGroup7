namespace DependencyInversion
{
    public class Report
    {
        private ISender sender;

        public Report(ISender sender)
        {
            this.sender = sender;
        }

        public void Send()
        {

            sender.Send();
        }
    }

    public interface ISender
    {
        void Send();
    }
    public class MailSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Mail ile gönderildi");
        }
    }

    public class WhatsAppSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("WhatsApp ile gönderildi");

        }
    }
}
