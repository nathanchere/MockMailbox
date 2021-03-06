﻿using System;
using MockMailbox;

namespace MockMailbox.EmailStyles
{
    public abstract class EmailStyleRandom : IEmailStyle
    {
        protected MarkovNameGenerator _names;
        protected string[] _domains;        

        private readonly Random _random = new Random();

        protected abstract void InitialiseNames();
        protected abstract void InitialiseDomains();

        public EmailStyleRandom()
        {
            InitialiseNames();
            InitialiseDomains();
        }

        public EmailAddress Generate()
        {            
            var name = _names.NextName();
            var domain = _domains[_random.Next(0, _domains.Length)];
            var result = new EmailAddress(name, domain);
            return result;
        }
    }
}