using System;
using System.Collections.Generic;

namespace Gander.Utils.DummyEmailGenerator
{
    public class EmailAddressGenerator : IEmailStyle
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
}