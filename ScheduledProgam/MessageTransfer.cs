using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using BusinessLayer1;
namespace ScheduledProgram
{

    public class MessageTransfer
    {
        public string gmailAppPassword = null;
        public string fromAddress = null;

        public void SendEmail()
        {
            // Your generated App Password goes here
            string gmailAppPassword = "bjcu kfii ufay xkqz";
            string fromAddress = "karthiselvi312004@gmail.com";
            // Get dynamic user input for 'toAddress', 'subject', and 'content'

            Console.WriteLine("Enter the recipient's email address:");
            var toAddress = Console.ReadLine();

            Console.WriteLine("Enter the email subject:");
            var subject = Console.ReadLine();

            Console.WriteLine("Enter the email content (HTML allowed):");
            var content = Console.ReadLine();




            //Create the BuiltInEmailServices object with user input
            var mailTransfer = new BuiltInEmailServices(fromAddress, toAddress, subject, content, gmailAppPassword);
            mailTransfer.MessageTransfer();

            //Create the MailAutomatedEmail object with user input
            //var email = new MailKitService(fromAddress, toAddress, subject, content, gmailAppPassword);
            //email.SendEmail();


        }
    }
}

