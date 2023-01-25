using BaseProject.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace WebApp.Observer.Observer
{
    public class UserObserverSendEmail : IUserObserver
    {
        private readonly IServiceProvider _serviceProvider;

        public UserObserverSendEmail(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void UserCreated(AppUser appUser)
        {
            var logger = _serviceProvider.GetRequiredService<ILogger<UserObserverSendEmail>>();
            var mailMessage = new MailMessage();
            var smptClient = new SmtpClient("***********");
            mailMessage.From = new MailAddress("************");
            mailMessage.To.Add(new MailAddress(appUser.Email));
            mailMessage.Subject = "Sitemize hoş geldiniz";
            mailMessage.Body = "<p>Sitemizin Genel Kuralları .....</p>";
            mailMessage.IsBodyHtml = true;
            smptClient.Port = 587;
            smptClient.Credentials = new NetworkCredential("******************", "*****************");
            smptClient.Send(mailMessage);
            logger.LogInformation($"Email gönderildi:{appUser.UserName }");

        }
    }
}
