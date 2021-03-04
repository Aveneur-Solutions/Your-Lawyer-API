using System.Threading.Tasks;
using Application.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Application.SMSService
{
       public static class AuthMessageSender 
    {
        


    
        public static Task SendEmailAsync(string email, string subject, string message)
        {
            // Plug in your email service here to send an email.
            return Task.FromResult(0);
        }

        public static Task SendSmsAsync(string number, string message,IConfiguration configuration)
        {
            // Plug in your SMS service here to send a text message.
            // Your Account SID from twilio.com/console
            var accountSid = configuration["SMSAccountIdentification"];
            // Your Auth Token from twilio.com/console
            var authToken = configuration["SMSAccountPassword"];

            TwilioClient.Init(accountSid, authToken);

            return MessageResource.CreateAsync(
              to: new PhoneNumber(number),
              from: new PhoneNumber(configuration["SMSAccountForm"]),
              body: message);
        }
    }
}