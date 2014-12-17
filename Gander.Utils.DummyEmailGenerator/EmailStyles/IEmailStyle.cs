﻿using System.Linq;

namespace Gander.Utils.DummyEmailGenerator
{
    public interface IEmailStyle
    {        
        EmailAddress Generate();
    }

    public class EmailStyleElf : EmailStyleRandom
    {
        protected override void InitialiseNames()
        {
            var seeds = new[]
            {
                "Aegnor",
                "Finrod",
                "Felagund",
                "Angrod",
                "Finarfin",
                "Valinor",
                "Andreth",
                "Aicanáro",
                "Amarië",
                "Amdír",
                "Thranduil",
                "Legolas",
                "Lothlórien",
                "Amroth",
                "Amras",
                "Aredhel",
                "Anairë",
                "Túrin",
                "Turambar",
                "Beleg",
                "Cúthalion",
                "Caranthir",
                "Celeborn",
                "Celebrian",
                "Celebrimbor",
                "Celegorm",
                "Cirdan",
                "Cirufin",
                "Daeron",
                "Doriath",
                "Thingol",
                "Fëanor",
                "Denethor",
                "Lenwë",
                "Duilin",
                "Eärwen",
                "Olwë",
                "Alqualondë",
                "Galadriel",
                "Lúthien",
                "Thingol",
                "Eärendil",
                "Ecthelion",
                "Eldalótë",
                "Elenwë",
                "Elrond",
                "Erestor",
                "Eöl",
                "Maeglin",
                "Finwë",
                "Noldóran",
                "Galadhon",
                "Galathil",
                "Galdor",
                "Gildor",
                "Inglorion",
                "Ereinion",
                "Gil-galad",
                "Artanáro",
                "Gimli",
                "Gwindor",
                "Guilin",
                "Haldir",
                "Iminyë",
                "Imin",
                "Lúthien",
                "Tinúviel",
                "Mablung",
                "Maedhros",
                "Maeglin",
                "Míriel",
                "Mithrellas",
                "Nerdanel",
                "Olwë",
                "Orodreth",
                "Pengolodh",
                "Onótimo",
                "Quennar",
                "Rúmil",
                "Saeros",
                "Thranduil",
                "Voronwë",
            };
            _names = new MarkovNameGenerator(seeds.Distinct(), 3, 2);
        }

        protected override void InitialiseDomains()
        {
            _domains = new[]
            {
                "aqualonde.com",
                "avallone.com",
                "brithombar.com",
                "carasgaladhon.com",
                "edhellond.com",
                "eglarest.com",
                "forlond.com",
                "formenos.com",
                "gondolin.com",
                "hallsofthranduil.gov",
                "harlond.com",
                "kortirion.com",
                "menegroth.com",
                "rivendell.com",
                "tavrobel.com",
                "tirion.com",
                "vinyamar.com",
                "lothlórien.net",
                "woodland.net",
                "mirkwood.net",
            };
        }
    }

    public class EmailStyleViking : EmailStyleRandom
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