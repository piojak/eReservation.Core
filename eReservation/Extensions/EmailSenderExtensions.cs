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
            return emailSender.SendEmailAsync(email, "Potwierd� sw�j email",
                $"Potwierd� swoje konto w serwisie eResrvation klikaj�c na poni�szy link: <a href='{HtmlEncoder.Default.Encode(link)}'>link</a>");
        }
    }
}
