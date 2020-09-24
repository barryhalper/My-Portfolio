using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.DataAccess;
using Portfolio.Business.Models;
using Portfolio.Core.Models;
using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;
using System.Linq.Expressions;
using Portfolio.Core.Utils;
using Portfolio.Core.Models.Appsettings;

namespace Portfolio.Core.Controllers
{
    public class ContactController : Controller
    {
        //local vars for this controller
        private IContactService service;
        private IMapper mapper;
        private IEmailConfiguration emailConfiguration;
        private IRenderViewService renderViewService;

        public ContactController(IContactService service, IMapper mapper, IEmailConfiguration emailConfiguration, IRenderViewService renderViewService) {
            this.service = service;
            this.mapper = mapper;
            this.emailConfiguration = emailConfiguration;
            this.renderViewService = renderViewService;
        }


        public IActionResult Index()
        {
            return View("ContactView");
        }

        [HttpPost]
        //ensure user security of post
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(ContactViewModel model)
        {
            //use model validations
            if (ModelState.IsValid)
            {   

                //save data to database
                service.CreateAysnc(mapper.Map<Contact>(model));
                //call service to execure view , pass model and return as string
                string view = "/Views/Email/contactNotification.cshtml";
                var htmlBody = await renderViewService.RenderViewToStringAsync(view, model);
                //send email notification
                await SendEmail(new EmailMessage
                {
                    Content = htmlBody,
                    Subject = "New post from my portfolio"
                });
                   

                return PartialView("_success", model);
            }
            else { 
                return PartialView("_contactFormView", model);
            }
        }


        private async Task SendEmail(EmailMessage emailMessage )
        {

            try
            {
                //set up message and mailbox settings from config
                var message = new MimeMessage();
                message.To.Add(new MailboxAddress(emailConfiguration.SenderName, emailConfiguration.Reciever));
                message.From.Add(new MailboxAddress(emailConfiguration.SenderName, emailConfiguration.SenderEmail));
                
                message.Subject = emailMessage.Subject;
                //We will say we are sending HTML. But there are options for plaintext etc. 
                message.Body = new TextPart(TextFormat.Html)
                {
                    Text = emailMessage.Content
                };

                //Be careful that the SmtpClient class is the one from Mailkit not the framework!
                using (var emailClient = new SmtpClient())
                {
                    //send async email to ensure threads don't bootleneck
                    await emailClient.ConnectAsync(emailConfiguration.SmtpServer, emailConfiguration.Port);
                    await emailClient.SendAsync(message);
                    await emailClient.DisconnectAsync(true);
                }
            }
            catch (Exception e) {
                throw new InvalidOperationException(e.Message);
            }

        }


    }
    
}
