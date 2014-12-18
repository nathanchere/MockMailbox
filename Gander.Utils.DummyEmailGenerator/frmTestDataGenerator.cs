using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gander.Utils.DummyEmailGenerator
{
    public partial class frmTestDataGenerator : Form
    {
        public frmTestDataGenerator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var count = Convert.ToInt32(numCountToGenerate.Value);
            var path = txtOutputPath.Text;

            Directory.Delete(path, true);

            GenerateMailbox("donatello", new EmailAddress("the.purple.turtle", "tmnt.com"), count, path, new EmailStyleNinjaTurtle());
            GenerateMailbox("bjornegar", new EmailAddress("bjornToBeWild", "festfyfan.com"), count, path, new EmailStyleViking());
            GenerateMailbox("nevafael", new EmailAddress("nevafael", "rivendell.com"), count, path, new EmailStyleElf());
        }

        private DateTime GetDateTime()
        {
            var start = dtmDateFrom.Value;
            var range = (dtmDateTo.Value - start).TotalDays;
            var random = new Random();
            var value = start
                .AddDays(random.Next((int)range))
                .AddHours(random.Next(23))
                .AddMinutes(random.Next(59))
                .AddSeconds(random.Next(59));
            return value;
        }

        private void GenerateMailbox(string username, EmailAddress to, int count, string outputPath, IEmailStyle style)
        {
            var emailGenerator = new EmailAddressGenerator();
            emailGenerator.AddStyle(style);            

            for (int i = 0; i < count; i++)
            {
                var id = Guid.NewGuid();
                var from = emailGenerator.Generate();
                var result = new DummyEmail()
                {
                    To = to.ToString(),
                    From = from.ToString(),
                    Sent = GetDateTime().ToString(),
                    Subject = "Hey something",
                    Body = "This is just a test email " + id,
                };

                var output = Path.Combine(outputPath, to.Name, id + ".txt");
                File.WriteAllText(output, result.ToString(), Encoding.UTF8);
            }
        }
                
    }
}
