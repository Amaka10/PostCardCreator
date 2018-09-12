using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Net.Mime;
using System.Web.Http;

namespace PostCardCreator.Controllers
{
   // [Route("PostCard/[action]")]
    public class PostCardController : ApiController
    {
       
        // POST api/SendEmail
        /// <summary>
        /// Gets DataUrl from image and sends to recip[ient's email
        /// </summary>
        /// <param name="Data"></param>
        public void SendEmail([FromBody]JObject Data)
        {
            var imgData = Data["imgData"].ToObject<string>();
            var emailTo = Data["emailTo"].ToObject<string>();
            var emailFrom = Data["emailFrom"].ToObject<string>();
            if (!String.IsNullOrEmpty(imgData) && !String.IsNullOrEmpty(emailTo) && !String.IsNullOrEmpty(emailFrom))
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    //smtphost has to be set
                    var smtp = System.Configuration.ConfigurationManager.AppSettings["smtp"].ToString();
                    SmtpClient SmtpServer = new SmtpClient(smtp)
                    {
                        //this option can be changed to use credentials
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false
                    };
                    mail.From = new MailAddress(emailFrom);
                    mail.To.Add(emailTo);
                    mail.Subject = $"Post Card From {mail.From}";
                    //render email body as html
                    mail.IsBodyHtml = true;
                    //attach html image to email body
                    mail.Body = $"<img src = {imgData} />";

                    SmtpServer.Send(mail);
                }
                catch (Exception)
                {

                    throw;
                }
               
            }
        }

    }
}