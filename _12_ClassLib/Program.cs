using _12_1_SendMessage;
using Microsoft.Extensions.Configuration;

namespace _12_ClassLib
{
    class Program
    {
        public static void Main()
        {
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"application.json");

            var config = configurationBuilder.Build();
            var emailConfig = config
                .GetSection("EmailConfiguration");
            var configuration = new EmailConfiguration()
            {
                From = emailConfig.GetSection("From").Value,
                SmtpServer = emailConfig.GetSection("SmtpServer").Value,
                Port = int.Parse(emailConfig.GetSection("Port").Value),
                UserName = emailConfig.GetSection("UserName").Value,
                Password = emailConfig.GetSection("Password").Value
            };
            SmtpEmailService emailService = new SmtpEmailService(configuration);


            // See https://aka.ms/new-console-template for more information
            Console.Write($"Sender `{configuration.From}` Enter email: ");
            string email=Console.ReadLine();
            Message message = new Message
            {
                Body = "Треба іти гулять",
                Subject = "Перевірка обстановкі",
                To = email
            };
            emailService.Send(message);


        }
    }
}

