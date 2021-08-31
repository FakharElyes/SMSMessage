using Microsoft.AspNetCore.Mvc;
using Nexmo.Api;
using SendSMSMessages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SendSMSMessages.Controllers
{
    public class SMSMessageController : Controller
    {

        string TutoLink = "https://www.c-sharpcorner.com/article/asp-net-mvc-sending-sms-messages-using-nexmo-api/";


        // GET: SMSMessage  
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendMessage(Message message)
        {
            var results = SMS.Send(new SMS.SMSRequest
            {
                from = Configuration.Instance.Settings["appsettings:NEXMO_FROM_NUMBER"],
                to = message.To,
                text = message.ContentMsg
            });


            return View();
        }
    }
}
