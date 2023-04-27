// See https://aka.ms/new-console-template for more information
using DependencyInversion;

Console.WriteLine("Hello, World!");
//Bir nesne var olmak için; bir başka nesneye ihtiyaç duyuyorsa; bu nesneyi dışardan almalıdır.
MailSender mailSender = new MailSender();
Report report = new Report(mailSender);
report.Send();

WhatsAppSender whatsAppSender = new WhatsAppSender();
Report report1 = new Report(whatsAppSender);

report1.Send();