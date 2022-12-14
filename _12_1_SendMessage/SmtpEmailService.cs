using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_SendMessage
{
    public class SmtpEmailService
    {
        private readonly EmailConfiguration _configuration;
        public SmtpEmailService(EmailConfiguration configuration)
        {
            _configuration = configuration;
            //_configuration = new EmailConfiguration()
            //{
            //    From = "super.novakvova@ukr.net",
            //    SmtpServer = "smtp.ukr.net",
            //    Port = 2525,
            //    UserName = "super.novakvova@ukr.net",
            //    Password = "cnNfnQDgjVmmEttB"
            //};
        }
        public void Send(Message message)
        {
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = message.Body;
            bodyBuilder.TextBody = "This is some plain text";
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress(_configuration.From));
            emailMessage.To.Add(new MailboxAddress(message.To));
            emailMessage.Subject = message.Subject;
            emailMessage.Body = bodyBuilder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                try
                {
                    client.Connect(_configuration.SmtpServer, _configuration.Port, true);
                    client.Authenticate(_configuration.UserName, _configuration.Password);
                    client.Send(emailMessage);
                    client.Disconnect(true);
                }
                catch
                {
                    throw;
                }
                finally
                {
                    client.Disconnect(true);
                    client.Dispose();
                }
            }
        }
    }
}
