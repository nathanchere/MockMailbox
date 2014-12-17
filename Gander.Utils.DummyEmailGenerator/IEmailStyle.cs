using System;

namespace Gander.Utils.DummyEmailGenerator
{
    public interface IEmailStyle
    {        
        EmailAddress Generate();
    }

    public abstract class EmailStyleLookup : IEmailStyle
    {
        protected string[] _names;
        protected string[] _domains;

        private readonly Random random = new Random();

        protected abstract void InitialiseNames();
        protected abstract void InitialiseDomains();

        public EmailAddress Generate()
        {
            var name = _names[random.Next(0, _names.Length)];
            var domain = _domains[random.Next(0, _domains.Length)];
            var result = new EmailAddress(name, domain);
            return result;
        }
    }

    public abstract class EmailStyleRandom : IEmailStyle
    {
        protected MarkovNameGenerator _names;
        protected string[] _domains;        

        private readonly Random random = new Random();

        protected abstract void InitialiseNames();
        protected abstract void InitialiseDomains();        

        public EmailAddress Generate()
        {            
            var name = _names.NextName();
            var domain = _domains[random.Next(0, _domains.Length)];
            var result = new EmailAddress(name, domain);
            return result;
        }
    }
}