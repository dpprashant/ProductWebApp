using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace ProductWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult SendEmail(string receiver, string subject, string message)
        public ActionResult SendEmail()
        {
            try
            {
                if (ModelState.IsValid)
                {

                    //MailMessage message = new MailMessage();
                    //message.From = new MailAddress("dpprashant1@gmail.com");

                    //message.To.Add(new MailAddress("info@risingtechlabs.com"));

                    //message.Subject = "your subject";
                    //message.Body = "content of your email";

                    //SmtpClient client = new SmtpClient();
                    //client.Send(message);

                    var smptClient = new SmtpClient("smtp.gmail.com", 587)
                    {
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential("dpprashant1@gmail.com", "9429715419@Heli"),
                        EnableSsl = true                       
                    };
                    smptClient.Send("bjrisingtechlabs@gmail.com", "dpprashant1@gmail.com", "Testing Email", "testing the email");


                    //var senderEmail = new MailAddress("bjrisingtechlabs@gmail.com", "PD");
                    //var receiverEmail = new MailAddress("dpprashant1@gmail.com", "Receiver");
                    //var password = "Jayesh@123";
                    //var sub = "Test";
                    //var body = "Testing";

                    //var smtp = new SmtpClient
                    //{
                    //    Host = "smtp.gmail.com",
                    //    Port = 587,
                    //    EnableSsl = true,
                    //    DeliveryMethod = SmtpDeliveryMethod.Network,
                    //    UseDefaultCredentials = false,
                    //    Credentials = new NetworkCredential(senderEmail.Address, password)
                    //};

                    //using (var mess = new MailMessage(senderEmail, receiverEmail)
                    //{
                    //    Subject = "Test email",
                    //    Body = body
                    //})
                    //{
                    //    smtp.Send(mess);
                    //}
                    return View();
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Some Error";
            }
            return View();
        }
    }
}