using System.Net.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LastApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LastApp.Pages
{
    public class ContactModel : PageModel
    {
        public string Message {get; set;}

        [BindProperty]
        public Email mail {get; set;}
         public void OnGet()
        {
            Message = "Your contact page";
        }
        public async Task OnPost()
        {
            using (var smpt = new SmtpClient())
            {
                smpt.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
                smpt.PickupDirectoryLocation = @"E:\Mymails";
                var msg = new MailMessage
                {
                    Body = mail.Body,
                    Subject = mail.Subject,
                    From = new MailAddress(mail.From)
                };
                msg.To.Add(mail.To);
                await smpt.SendMailAsync(msg);
            }
        }
        
    }
}
