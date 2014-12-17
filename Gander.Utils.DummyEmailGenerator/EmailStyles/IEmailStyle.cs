namespace Gander.Utils.DummyEmailGenerator
{
    public interface IEmailStyle
    {
        EmailAddress Generate();
    }

    public class EmailStyleGreek : EmailStyleRandom
    {
        protected override void InitialiseNames()
        {
            var seeds = new[]
            {
                "",
            };
            _names = new MarkovNameGenerator(seeds, 3, 2);
        }

        protected override void InitialiseDomains()
        {
            _domains = new[]
            {
                "",
            };
        }
    }

    public class EmailStyle : EmailStyleRandom
    {
        protected override void InitialiseNames()
        {
            var seeds = new[]
            {
                "",
            };
            _names = new MarkovNameGenerator(seeds, 3, 2);
        }

        protected override void InitialiseDomains()
        {
            _domains = new[]
            {
                "",
            };
        }
    }
}