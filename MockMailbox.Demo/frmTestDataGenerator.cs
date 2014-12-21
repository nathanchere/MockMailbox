using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MockMailbox.EmailStyles;

namespace MockMailbox
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

            if (Directory.Exists(txtOutputPath.Text)) Directory.Delete(txtOutputPath.Text, true);

            GenerateMailbox("donatello", new EmailAddress("the.purple.turtle", "tmnt.com"), count, new EmailStyleNinjaTurtle());
            GenerateMailbox("bjornegar", new EmailAddress("bjornToBeWild", "festfyfan.com"), count, new EmailStyleViking());
            GenerateMailbox("nevafael", new EmailAddress("nevafael", "rivendell.com"), count, new EmailStyleElf());

            Process.Start(txtOutputPath.Text);
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

        private void GenerateMailbox(string username, EmailAddress to, int count, IEmailStyle style)
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

                var outPath = Path.Combine(txtOutputPath.Text, to.Name);
                var outFile = Path.Combine(outPath, id + ".txt");
                Directory.CreateDirectory(outPath);
                File.WriteAllText(outFile, result.ToString(), Encoding.UTF8);
            }
        }
                
    }
}
