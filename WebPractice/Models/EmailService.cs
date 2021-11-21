using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Net.Mail;
using System.Threading.Tasks;
using MailKit.Net.Smtp;

namespace WebPractice.Models
{
    public class EmailService
    {
        public void SendEmail(string Name, string Email, string Password, string Message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress(" ", Email));
            emailMessage.To.Add(new MailboxAddress(" ", "kirya.krotov.03@mail.ru"));
            emailMessage.Subject = Name;
            emailMessage.Body = new TextPart("Plain")
            {
                Text = Message
            };

            using (var client = new SmtpClient())
            {
                try
                {
                    //client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    client.Connect("smtp.mail.ru", 465, true); //587
                    //client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate(Email, Password);
                    client.Send(emailMessage);

                    client.Disconnect(true);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}