using System;

namespace Gander.Utils.DummyEmailGenerator
{
    public abstract class EmailStyleRandom : IEmailStyle
    {
        protected MarkovNameGenerator _names;
        protected string[] _domains;        

        private readonly Random _random = new Random();

        protected abstract void InitialiseNames();
        protected abstract void InitialiseDomains();        

        public EmailAddress Generate()
        {            
            var name = _names.NextName();
            var domain = _domains[_random.Next(0, _domains.Length)];
            var result = new EmailAddress(name, domain);
            return result;
        }
    }
}