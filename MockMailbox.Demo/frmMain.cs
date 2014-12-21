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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var count = Convert.ToInt32(numCountToGenerate.Value);
            var path = txtOutputPath.Text;
            GenerateEmails(count, path);
        }

        private void GenerateEmails(int count, string outputPath)
        {
            var emailAddresses = GetEmailAddressGenerator();

            for (int i = 0; i < count; i++)
            {
                var id = Guid.NewGuid();

                var email = emailAddresses.Generate();
                var result = new DummyEmail()
                {
                    To =  "you",
                    From = email.ToString(),
                    Sent = DateTime.Now.ToString(),
                    Subject = "Hey something",
                    Body = "This is just a test email " + id,
                };

                var output = Path.Combine(outputPath, id + ".txt");
                File.WriteAllText(output, result.ToString(), Encoding.UTF8);
            }
        }

        private EmailAddressGenerator GetEmailAddressGenerator()
        {
            var result = new EmailAddressGenerator();
            if (chkStyleElf.Checked) result.AddStyle(new EmailStyleElf());
            if (chkStyleGreek.Checked) result.AddStyle(new EmailStyleGreek());
            if (chkStyleNinjaTurtle.Checked) result.AddStyle(new EmailStyleNinjaTurtle());
            if (chkStyleViking.Checked) result.AddStyle(new EmailStyleViking());
            return result;
            
        }   
    }   
}
