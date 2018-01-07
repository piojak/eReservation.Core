using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using eReservation.Services;

namespace eReservation.Services
{
    public static class EmailSenderExtensions
    {
        public static Task SendEmailConfirmationAsync(this IEmailSender emailSender, string email, string link)
        {
            return emailSender.SendEmailAsync(email, "Potwierdü swÛj email",
                $"Potwierdü swoje konto w serwisie eResrvation klikajπc na poniøszy link: <a href='{HtmlEncoder.Default.Encode(link)}'>link</a>");
        }
    }
}
