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

        public static Task SendSmsAsync(string number, string message, IConfiguration configuration)
        {
            // Plug in your SMS service here to send a text message.
            // Your Account SID from twilio.com/console
            // configuration["SMSAccountIdentification"];
            var accountSid = "AC37b2f92cb1260c2b17853791fbe9c48c";
            // Your Auth Token from twilio.com/console
            // var authToken = configuration["SMSAccountPassword"];
            var authToken = "028699d10ce9aec10b855982b780d7c9";
            // var fromNumber = configuration["SMSAccountFrom"];
            var fromNumber = "+12013748913";

            TwilioClient.Init(accountSid, authToken);

            return MessageResource.CreateAsync(
              to: new PhoneNumber(number),
              from: new PhoneNumber(fromNumber),
              body: message);
        }
    }
}