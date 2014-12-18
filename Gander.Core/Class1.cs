using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Pop3;

namespace Gander.Core
{
    public class AccountCredentials
    {
        public AccountCredentials(string username, string password)
        {
            UserName = username;
            Password = password;
        }

        public string UserName { get; set; }
        public string Password { get; set; }      
    }

    public class AccountSettings
    {
        public AccountCredentials Credentials { get; set; }
        public string ServerUri { get; set; }
        public int ServerPort { get; set; }

        public string EmailAddress { get; set; }

        // HTTPS etc
    }

    public class MailClient
    {
        public void GetEmails(AccountSettings settings)
        {
            using (var client = new Pop3Client())
            {
                client.Connect(settings.ServerUri, settings.ServerPort);

                // Note: since we don't have an OAuth2 token, disable
                // the XOAUTH2 authentication mechanism.
                client.AuthenticationMechanisms.Remove("XOAUTH2");

                client.Authenticate(settings.Credentials.UserName, settings.Credentials.Password);

                int count = client.GetMessageCount();
                for (int i = 0; i < count; i++)
                {
                    var message = client.GetMessage(i);
                    Console.WriteLine("From: {0}", message.From);
                    Console.WriteLine("Date: {0}", message.Date);
                    Console.WriteLine("Subject: {0}", message.Subject);
                    Console.WriteLine(message.Body);

                }

                client.Disconnect(true);
            }
        }
    }
}
