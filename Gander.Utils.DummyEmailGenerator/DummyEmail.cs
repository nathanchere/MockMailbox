using System.Text;

namespace Gander.Utils.DummyEmailGenerator
{
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