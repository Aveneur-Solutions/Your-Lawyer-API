using System;
using System.Threading.Tasks;
using Application.SMSService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace API.Controllers
{
    public class MessageController : ControllerBase
    {

        private readonly IConfiguration _config;

        public MessageController(IConfiguration config)
        {
            _config = config;

        }

        [HttpPost("message")]
        [AllowAnonymous]
        public async void Message()
        {

            Random r = new Random();
            int randNum = r.Next(1000000);
            string sixDigitNumber = randNum.ToString("D6");
            await AuthMessageSender.SendSmsAsync("+8801680800602", "Hello MD",_config);
        }


    }
}