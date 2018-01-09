using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace eReservation.Services
{
    // This class is used by the application to send email for account confirmation and password reset.
    // For more details see https://go.microsoft.com/fwlink/?LinkID=532713
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
           // return Task.CompletedTask;
            return Task.Run(() => SendByGmail(email, subject, message));
        }

        private async Task<bool> SendByGmail(string email, string subject, string body)
        {
            try
            { 
            var fromAddress = new MailAddress("ereservation111@gmail.com", "eReservation");
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("ereservation111@gmail.com", "ereservation123")
            };
            using (var message = new MailMessage(fromAddress, new MailAddress(email))
            {
                Subject = subject,
                Body = body
            })
            {
                await smtp.SendMailAsync(message);
                return true;
            }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
