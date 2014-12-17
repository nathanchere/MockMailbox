using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gander.Core
{
    public class AccountCredentials
    {
        public string EmailAddress { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class MailClient
    {
        public void GetEmails()
        {
            using (var client = new Pop3Client())
            {
                client.Connect("pop.friends.com", 110, false);

                // Note: since we don't have an OAuth2 token, disable
                // the XOAUTH2 authentication mechanism.
                client.AuthenticationMechanisms.Remove("XOAUTH2");

                client.Authenticate("joey", "password");

                int count = client.GetMessageCount();
                for (int i = 0; i < count; i++)
                {
                    var message = client.GetMessage(i);
                    Console.WriteLine("Subject: {0}", message.Subject);
                }

                client.Disconnect(true);
            }
        }
    }
}
