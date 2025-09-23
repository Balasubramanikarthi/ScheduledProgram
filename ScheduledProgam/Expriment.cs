using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ScheduledProgram
{
    class Expriment
    {
        public void SendEmails()
        {
            // Your generated App Password goes here
            string gmailAppPassword = "bjcu kfii ufay xkqz";
            string fromAddress = "karthiselvi312004@gmail.com";
            string toAddress = "karthikeyan.selvisubramani@gmail.com";

            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(fromAddress);
                    mail.To.Add(toAddress);
                    mail.Subject = "Test Email from C#";
                    mail.Body = "<h1>Hello!</h1><p>This is a test email sent from C# using the Gmail SMTP server.</p>" + "My Name Is B.Karthikeyan ";
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential(fromAddress, gmailAppPassword);
                        smtp.EnableSsl = true;
                        smtp.UseDefaultCredentials = false;

                        smtp.Send(mail);
                        Console.WriteLine("Email sent successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to send email: " + ex.Message);
            }
        }



    }

}

