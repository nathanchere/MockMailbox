using System;

namespace MockMailbox.EmailStyles
{
    public interface IEmailStyle
    {
        EmailAddress Generate();
    }

    public class EmailStyleGreek : EmailStyleRandom
    {
        protected override void InitialiseNames()
        {
            throw new NotImplementedException();
            var seeds = new[]
            {
                "",
            };
            _names = new MarkovNameGenerator(seeds, 3, 2);
        }

        protected override void InitialiseDomains()
        {
            throw new NotImplementedException();
            _domains = new[]
            {
                "",
            };
        }
    }

    //public class EmailStyle : EmailStyleRandom
    //{
    //    protected override void InitialiseNames()
    //    {
    //        var seeds = new[]
    //        {
    //            "",
    //        };
    //        _names = new MarkovNameGenerator(seeds, 3, 2);
    //    }

    //    protected override void InitialiseDomains()
    //    {
    //        _domains = new[]
    //        {
    //            "",
    //        };
    //    }
    //}
}