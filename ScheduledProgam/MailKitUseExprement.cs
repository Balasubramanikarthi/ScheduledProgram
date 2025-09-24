using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;


namespace ScheduledProgram
{
   
    public class MailKitUseExprement
    {
        public async Task SendEmailAsync()
        {
            // Your generated App Password goes here
            string gmailAppPassword = "YOUR_16_DIGIT_APP_PASSWORD";
            string fromAddress = "your.email@gmail.com";
            string toAddress = "recipient.email@example.com";

            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("Sender Name", fromAddress));
            email.To.Add(new MailboxAddress("Recipient Name", toAddress));
            email.Subject = "Test Email from C# (MailKit)";
            email.Body = new TextPart("plain")
            {
                Text = "This is a test email sent using MailKit."
            };

            try
            {
                using (var smtp = new SmtpClient())
                {
                    await smtp.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                    await smtp.AuthenticateAsync(fromAddress, gmailAppPassword);
                    await smtp.SendAsync(email);
                    await smtp.DisconnectAsync(true);
                    Console.WriteLine("Email sent successfully!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to send email: " + ex.Message);
            }
        }
    }

}

    

