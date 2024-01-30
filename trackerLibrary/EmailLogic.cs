using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace TrackerLibrary
{
    public static class EmailLogic
    {
        public static void SendEmail(string to, string subject, string body)
        {
            SendEmail(new List<string> { to }, new List<string>(), subject, body);
        }

        public static void SendEmail(List<string> to,List<string>bcc, string subject, string body)
        {

            string smtpServer = ConfigurationManager.AppSettings["SmtpServer"];
            int smtpPort = int.Parse(ConfigurationManager.AppSettings["SmtpPort"]);
            string fromAddress = ConfigurationManager.AppSettings["SenderEmail"];
            string userName = ConfigurationManager.AppSettings["SmtpUserName"];
            string password = ConfigurationManager.AppSettings["SmtpPassword"];


            MailAddress fromMailAddress = new MailAddress(GlobalConfig.AppKeyLookUp("senderEmail"),GlobalConfig.AppKeyLookUp("senderDisplayName"));
            MailMessage mail = new MailMessage();
            foreach(string email in to)
            {
                mail.To.Add(email);
            }
            foreach (string email in bcc)
            {
                mail.Bcc.Add(email);
            }

            mail.From = fromMailAddress;
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();
            client.Host = smtpServer;
            client.Port = smtpPort;
            client.Credentials = new System.Net.NetworkCredential(userName, password);
            client.EnableSsl = true;

            client.Send(mail);
        }
    }
}
