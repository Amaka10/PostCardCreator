using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet;

namespace PostCardCreator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public void SendEmail( string imageData)
        {
            MailMessage mail = new MailMessage();
            //string jsonData = Request.Form[0];
            //SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            //SmtpClient SmtpServer = new SmtpClient("192.168.1.254");
            SmtpClient SmtpServer = new SmtpClient("172.16.4.30")
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false
            };
            //SmtpServer.UseDefaultCredentials = true;
            mail.From = new MailAddress("kallydoh@gmail.com");
            mail.To.Add("gailystar20@yahoo.com");
            mail.Subject = "Test Mail - 1";
            mail.Body = "mail with attachment";

           // System.Net.Mail.Attachment attachment;
           // attachment = new System.Net.Mail.Attachment("c:/textfile.txt");
           // mail.Attachments.Add(attachment);

          //  SmtpServer.Port = 60;
           // SmtpServer.Credentials = new System.Net.NetworkCredential("kallydoh@gmail.com", "under500");
           // SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }
    }
}