using Microsoft.AspNetCore.Identity.UI.Services;

namespace Bookstore.Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //for future (send email logic will be here)
            return Task.CompletedTask;
        }
    }
}
