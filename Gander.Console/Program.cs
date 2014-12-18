using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gander.Core;

namespace Gander.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new MailClient();
            client.GetEmails(new AccountSettings
            {
                ServerUri = "localhost",
                ServerPort = 110,
                Credentials = new AccountCredentials("the.purple.turtle", "password")
            });
            System.Console.ReadKey();
        }
    }
}
