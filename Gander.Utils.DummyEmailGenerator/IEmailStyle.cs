using System;
using System.Collections.Generic;

namespace Gander.Utils.DummyEmailGenerator
{
    public interface IEmailStyle
    {        
        EmailAddress Generate();
    }

    public class EmailGenerator
    {
        private readonly List<IEmailStyle> _emailStyles = new List<IEmailStyle>();
        private readonly Random _random = new Random();

        public void AddStyle(IEmailStyle style)
        {
            _emailStyles.Add(style);
        }

        public EmailAddress Generate()
        {
            var index = _random.Next(0, _emailStyles.Count);
            return _emailStyles[index].Generate();
        }
    }

    public abstract class EmailStyleLookup : IEmailStyle
    {
        protected string[] _names;
        protected string[] _domains;

        private readonly Random _random = new Random();

        protected abstract void InitialiseNames();
        protected abstract void InitialiseDomains();

        public EmailAddress Generate()
        {
            var name = _names[_random.Next(0, _names.Length)];
            var domain = _domains[_random.Next(0, _domains.Length)];
            var result = new EmailAddress(name, domain);
            return result;
        }
    }

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