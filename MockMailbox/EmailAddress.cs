namespace MockMailbox
{
    public class EmailAddress
    {
        public string Name { get; private set; }
        public string Email { get; private set; }

        public EmailAddress(string name, string email)
        {
            Name = name;
            Email = string.Format("{0}@{1}", name.ToLower(), email).Replace(' ','_');
        }

        public override string ToString()
        {
            if (!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Email)) return string.Format("{0} <{1}>", Name, Email);
            if (!string.IsNullOrEmpty(Name)) return Name;
            if (!string.IsNullOrEmpty(Email)) return Email;
            return "";
        }
    }
}