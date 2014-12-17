namespace Gander.Utils.DummyEmailGenerator
{
    public class EmailStyleNinjaTurtle : EmailStyleLookup
    {       
        protected override void InitialiseNames()
        {
            _names = new[]
            {
                "Michaelangelo",
                "Donatello",
                "Raphael",
                "Leonardo",
                "Splinter",
                "Shredder",
                "Krang",
                "Bebop",
                "Rocksteady",
                "April O'Neil",
                "Casey Jones",
                "Leatherhead",
                "Metalhead",
                "Attilla the Frog",
                "Genghis Frog",
                "Napoleon Bonafrog",
                "Rasputin the Mad Frog",
                "Rat King",
                "Ace Duck",
                "Miyamoto Usagi",
                "General Traag",
                "Wingnut",
                "Screwloose",
                "Zak Neutrino",
                "Dask Neutrino",
                "Kala Neutrino",                
                "Tatsu",
                "Vernon Fenwick",
                "Hamato Yoshi",
                "Oroku Saki",
                "Irma Langinstein",
                "Burne Thompson",
                "Mondo Gecko",
                "Chrome Dome",
            };
        }

        protected override void InitialiseDomains()
        {
            _domains = new[]
            {
                "turtlepower.org",
                "cowabunga.net",
                "dimension-x.com",
                "technodrome.gov",
                "channel6.org",
                "ninjaturtles.com",
                "thefootclan.org",
                "pizzatime.com",
                "stockmanindustries.com",
                "news.channel6.org",
                "shellmail.net",
            };
        }
    }
}