using System;

namespace Gander.Utils.DummyEmailGenerator
{
    public abstract class EmailStyleLookup : IEmailStyle
    {
        protected string[] _names;
        protected string[] _domains;

        private readonly Random _random = new Random();

        protected abstract void InitialiseNames();
        protected abstract void InitialiseDomains();

        public EmailStyleLookup()
        {
            InitialiseNames();
            InitialiseDomains();
        }

        public EmailAddress Generate()
        {
            var name = _names[_random.Next(0, _names.Length)];
            var domain = _domains[_random.Next(0, _domains.Length)];
            var result = new EmailAddress(name, domain);
            return result;
        }
    }
}