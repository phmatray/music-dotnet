using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace MidiMinuit.Startup.Services
{
    // This class is used by the application to send Email and SMS
    // when you turn on two-factor authentication in ASP.NET Identity.
    // For more details see this link https://go.microsoft.com/fwlink/?LinkID=532713
    public class AuthMessageSender : IEmailSender, ISmsSender
    {
        public AuthMessageSender(IOptions<AuthMessageSenderOptions> optionsAccessor, IOptions<SMSoptions> smsOptionsAccessor)
        {
            Options = optionsAccessor.Value;
            SmsOptions = smsOptionsAccessor.Value;
        }

        public AuthMessageSenderOptions Options { get; } //set only via Secret Manager
        public SMSoptions SmsOptions { get; }  // set only via Secret Manager

        public Task SendEmailAsync(string email, string subject, string message)
        {
            // Plug in your email service here to send an email.
            Execute(Options.SendGridKey, subject, message, email).Wait();
            return Task.FromResult(0);
        }

        public async Task Execute(string apiKey, string subject, string message, string email)
        {
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("Philippe@startup.com", "Startup"),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };
            msg.AddTo(new EmailAddress(email));
            var response = await client.SendEmailAsync(msg);
        }

        public Task SendSmsAsync(string number, string message)
        {
            // Plug in your SMS service here to send a text message.
            // Your Account SID from twilio.com/console
            var accountSid = SmsOptions.TwilioAccountSid;
            // Your Auth Token from twilio.com/console
            var authToken = SmsOptions.TwilioAuthToken;

            TwilioClient.Init(accountSid, authToken);

            var msg = MessageResource.Create(
                to: new PhoneNumber(number),
                from: new PhoneNumber("+15005550006"),
                body: message);
            return Task.FromResult(0);
        }
    }
}
