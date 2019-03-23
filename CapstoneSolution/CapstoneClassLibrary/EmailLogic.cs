using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace CapstoneClassLibrary
{
    public static class EmailLogic
    {
        

        //This will be used to send emails
        public static void SendEmail(string to, string subject, string body)
        {
            string adminEmail = "cp5k.owner@gmail.com"; //User login credential

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Settings for gmail
            client.UseDefaultCredentials = false; //required by gmail smtp
            client.EnableSsl = true; //required by gmail smtp
            client.Credentials = new System.Net.NetworkCredential(adminEmail, "Password!@#"); //hardcoded password

            //Basics of en email
            MailAddress fromMailAddress = new MailAddress(adminEmail); //admin username
            MailMessage mail = new MailMessage();
            //Everything here needs to get passed when calling SendEmail(from, )
            mail.To.Add(to); 
            mail.From = fromMailAddress;
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = false;

           

            client.Send(mail);

            
        
        }
    }
}
