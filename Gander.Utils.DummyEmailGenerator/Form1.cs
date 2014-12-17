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
    public partial class Form1 : Form
    {
        public Form1()
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
            var seed = GetNameSeeds();
            var names = new MarkovNameGenerator(seed, 1, 5);

            for (int i = 0; i < count; i++)
            {
                var id = Guid.NewGuid();

                var name = names.NextName();
                var email = name + "@somedomain.com";
                var result = new DummyEmail()
                {
                    To =  "you",
                    From = new EmailAddress(name, email).ToString(),
                    Sent = DateTime.Now.ToString(),
                    Subject = "Hey something",
                    Body = "This is just a test email " + id,
                };

                var output = Path.Combine(outputPath, id + ".txt");
                File.WriteAllText(output, result.ToString(), Encoding.UTF8);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeSeedValues();
        }

        private void InitializeSeedValues()
        {
            chk
        }

        public List<string> GetNameSeeds()
        {
            var result = new List<string>();
            foreach (var control in grpNameStyles.Controls)
            {
                var current = control as CheckBox;
                if (current == null) continue;
                if (!current.Checked) continue;

                var seedValues = current.Tag as List<string>;
                result.AddRange(seedValues);
            }
            return result;
        }
    }

    public class EmailAddress
    {
        private readonly string _name;
        private readonly string _email;

        public EmailAddress(string email)
        {
            _email = email;
        }

        public EmailAddress(string name, string email)
        {
            _name = name;
            _email = email;
        }

        public override string ToString()
        {
            if (!string.IsNullOrEmpty(_name) && !string.IsNullOrEmpty(_email)) return string.Format("{0} <{1}>", _name, _email);
            if (!string.IsNullOrEmpty(_name)) return _name;
            if (!string.IsNullOrEmpty(_email)) return _email;
            return "";
        }
    }

    public class DummyEmail
    {
        public string To;
        public string From;
        public string Sent;
        public string CC;
        public string Subject;        
        public string Body;

        public override string ToString()
        {
            var result = new StringBuilder();
            if (!string.IsNullOrEmpty(From)) result.AppendLine(string.Format("From:\t{0}", From));
            if (!string.IsNullOrEmpty(Sent)) result.AppendLine(string.Format("Sent:\t{0}", Sent));
            if (!string.IsNullOrEmpty(To)) result.AppendLine(string.Format("To:\t{0}", To));
            if (!string.IsNullOrEmpty(CC)) result.AppendLine(string.Format("CC:\t{0}", CC));
            if (!string.IsNullOrEmpty(Subject)) result.AppendLine(string.Format("Subject:\t{0}", Subject));
            if (!string.IsNullOrEmpty(Body)) result.AppendLine(Body);
            return result.ToString();
        }
    }
}
