﻿namespace Gander.Utils.DummyEmailGenerator
{
    public class EmailStyleViking : EmailStyleRandom
    {
        protected override void InitialiseNames()
        {
            var seeds = new[]
            {
                "Æinridi",
                "Æirik",
                "Ærinmund",
                "Ærnmund",
                "Æsbiorn",
                "Æskil",
                "Æstrid",
                "Agnar",
                "Aki",
                "Aldis",
                "Alf",
                "Alfarin",
                "Alfdis",
                "Alfgeir",
                "Ali",
                "Alof",
                "Alrik",
                "Alvi",
                "Amundi",
                "Andvett",
                "Anund",
                "Arfast",
                "Ari",
                "Arinbjorn",
                "Armod",
                "Armod",
                "Arnbjorn",
                "Arnfinn",
                "Arngeir",
                "Arngrim",
                "Arni",
                "Arnkel",
                "Arnor",
                "Arnora",
                "Arnstein",
                "Arnthrud",
                "Arnvid",
                "Asbjorn",
                "Asdis",
                "Asgaut",
                "Asgeir",
                "Asgerd",
                "Asgöta",
                "Asgrim",
                "Ashild",
                "Aslak",
                "Asmund",
                "Åsmund",
                "Assur",
                "Asta",
                "Astrid",
                "Asvald",
                "Asvid",
                "Athils",
                "Atli",
                "Aud",
                "Audgisil",
                "Audun",
                "Auðunar",
                "Authun",
                "Banki",
                "Bard",
                "Bardi",
                "Beigarth",
                "Beiner",
                "Bera",
                "Berg",
                "Bergfinn",
                "Bergljot",
                "Bergthor",
                "Bergthora",
                "Bergvid",
                "Bersi",
                "Bjalki",
                "Bjarki",
                "Bjarni",
                "Bjor",
                "Bjorg",
                "Bjorgolf",
                "Bjorn, Biorn ",
                "Blæik",
                "Blæng",
                "Blesi",
                "Boe",
                "Bolla",
                "Bolli",
                "Bolverk",
                "Bork",
                "Bothvar",
                "Bræsi",
                "Bram",
                "Brand",
                "Brodd-Helgi",
                "Broddi",
                "Bruni",
                "Bui",
                "Byrnjolf",
                "Dalla",
                "Dan",
                "Diarf",
                "Dotta",
                "Drifa",
                "Droplaug",
                "Edgar",
                "Egil",
                "Eid",
                "Eilif",
                "Einar",
                "Eindridi",
                "Eirik",
                "Eldgrim",
                "Elgfrothi",
                "Engli",
                "Erlend",
                "Erp",
                "Eyjolf",
                "Eystein",
                "Eyvind",
                "Fastvi",
                "Finn",
                "Finnvid",
                "Floki",
                "Flosi",
                "Folder",
                "Folkbiorn",
                "Folkmar",
                "Freygerd",
                "Freystein",
                "Fridgeir",
                "Frodi",
                "Frømund",
                "Frothi",
                "Gæda",
                "Gæierlaug",
                "Gæira",
                "Gæirmund",
                "Gæirvi",
                "Gærhialm",
                "Gærrar",
                "Galti",
                "Gamal",
                "Gärdar",
                "Gaut",
                "Gauti",
                "Geir",
                "Geirhild",
                "Geirmund",
                "Geirny",
                "Geirstein",
                "Geitir",
                "Gellir",
                "Geri",
                "Gerrid",
                "Gest",
                "Giermund",
                "Gilli",
                "Gils",
                "Ginna",
                "Gizor",
                "Gizur",
                "Gjaflaug",
                "Glum",
                "Gnupa",
                "Gorm",
                "Grani",
                "Greiland",
                "Grelod",
                "Gretter",
                "Grim",
                "Grima",
                "Griotgard",
                "Gro",
                "Groa",
                "Guda",
                "Gudlang",
                "Gudmund",
                "Gudny",
                "Guðný",
                "Gudrid",
                "Gudrik",
                "Gudrod",
                "Gudrun",
                "Gudvær",
                "Gufi",
                "Gulla",
                "Gulli",
                "Gunbjorn",
                "Gunnald",
                "Gunnar",
                "Gunnbjorn",
                "Gunnhild",
                "Gunnkel",
                "Gunnlæif",
                "Gunnlaug",
                "Gunnvid",
                "Guthorm",
                "Gylfi",
                "Gyrd",
                "Hadd",
                "Hæfnir",
                "Hælæif",
                "Hælgi",
                "Hæming",
                "Haki",
                "Haklang",
                "Hakon",
                "Halfdan",
                "Hall",
                "Halla",
                "Hallbera",
                "Hallbjorn",
                "Halldis",
                "Halldor",
                "Hallfred",
                "Hallfrid",
                "Hallgerd",
                "Halli",
                "Hallkatla",
                "Hallkel",
                "Hallstein",
                "Hallvard",
                "Hallveig",
                "Halvdan",
                "Ham",
                "Häming",
                "Harald",
                "Hard",
                "Hardbein",
                "Hardrefil",
                "Hastein",
                "Hauk",
                "Havard",
                "Hedin",
                "Hedinfrid",
                "Heith",
                "Helga",
                "Helgi",
                "Heming",
                "Herdis",
                "Heriolf",
                "Herjolf",
                "Herkja",
                "Herlu",
                "Hermund",
                "Herstein",
                "Hialti",
                "Hild",
                "Hildigunn",
                "Hiorvard",
                "Hjalti",
                "Hjort",
                "Hjorvarth",
                "Hlif",
                "Hlodvir",
                "Hogni",
                "Holm",
                "Holmfast",
                "Holmfrid",
                "Holmlaug",
                "Holmstæin",
                "Holmstein",
                "Hord",
                "Hoskuld",
                "Hott",
                "Hrærek",
                "Hrafn",
                "Hrafnkel",
                "Hrani",
                "Hrapp",
                "Hrefna",
                "Hreida",
                "Hreidar",
                "Hring",
                "Hroald",
                "Hroar",
                "Hrodgæir",
                "Hrodgeir",
                "Hrodi",
                "Hrodny",
                "Hrok",
                "Hrolf",
                "Hromund",
                "Hrosskell",
                "Hrossketil",
                "Hrut",
                "Hunbogi",
                "Hundi",
                "Hungerd",
                "Hvitserk",
                "Iarl",
                "Iarlabanki",
                "Iarund",
                "Illugi",
                "Inga",
                "Ingegärd",
                "Ingeltore",
                "Ingibjorg",
                "Ingibjorg",
                "Ingifast",
                "Ingigerd",
                "Ingimar",
                "Ingimund",
                "Ingirun",
                "Ingithora",
                "Ingjald",
                "Ingrid",
                "Ingulbjörn",
                "Ingulfrid",
                "Ingun",
                "Ingvar",
                "Iogæir",
                "Iorund",
                "Irenmund",
                "Isleif",
                "Iuli",
                "Ivar",
                "Jarlebanke",
                "Jarngerd",
                "Jarnskeggi",
                "Jofrid",
                "Johan",
                "Jon",
                "Jorund",
                "Jorunn",
                "Kabbi",
                "Kadlin",
                "Kætil",
                "Kætilfast",
                "Kætilmund",
                "Kætiløy",
                "Kalf",
                "Kalv",
                "Kar",
                "Käre",
                "Kari",
                "Karl",
                "Karli",
                "Karsi",
                "Ketilbiorn",
                "Ketill",
                "Kisping",
                "Kiti",
                "Kjallak",
                "Kjartan",
                "Klint",
                "Knut",
                "Knútr",
                "Kodran",
                "Kol",
                "Kolbein",
                "Kolfinn",
                "Koll",
                "Kollskegg",
                "Kollsvein",
                "Kori",
                "Kotkell",
                "Kraki",
                "Kveldulf",
                "Lambi",
                "Leif",
                "Leiknir",
                "Lifstæn",
                "Lini",
                "Liut",
                "Ljot",
                "Ljufu",
                "Ludin",
                "Lyting",
                "Magnus",
                "Mani",
                "Manni",
                "Mar",
                "Maria",
                "Matilda",
                "Meldun",
                "Melkorka",
                "Moldof",
                "Mord",
                "Mursi",
                "Mus-Gia",
                "Naddod",
                "Nafni",
                "Nasi",
                "Näv",
                "Nidbiorg",
                "Nikolas",
                "Njal",
                "Northri",
                "Odd",
                "Oddbjorg",
                "Oddløg",
                "Oddny",
                "Ofieg",
                "Ogn",
                "Olæ",
                "Olæif",
                "Olaf",
                "Oleif",
                "Olvir",
                "Onäm",
                "Onund",
                "Øpir",
                "Orlyg",
                "Orm",
                "Orn",
                "Ornolf",
                "Orøkia",
                "Osk",
                "Ospak",
                "Osvald",
                "Osvif",
                "Otkel",
                "Otrygg",
                "Ottar",
                "Øvind",
                "Øybiorn",
                "Oystæin",
                "Øystæin",
                "Øysten",
                "Ozur",
                "Paul",
                "Rafarta",
                "Raghild",
                "Ragi",
                "Ragnar",
                "Ragnfast",
                "Ragnfrid",
                "Ragnvald",
                "Rannveig",
                "Raudebjorn",
                "Ref",
                "Regin",
                "Reinn",
                "Rodmar",
                "Rognvald",
                "Runa",
                "Runolf",
                "Sæbbi",
                "Sæmund",
                "Sæunn",
                "Sævil",
                "Saksi",
                "Sam",
                "Saxi",
                "Sibbe",
                "Sibbi",
                "Sigfast",
                "Sighvat",
                "Sigmund",
                "Signy",
                "Sigrid",
                "Sigurd",
                "Sigvaldi",
                "Sigvat",
                "Sigvid",
                "Sinfiotli",
                "Själve",
                "Skallagrim",
                "Skamkel",
                "Skap",
                "Skapti",
                "Skard",
                "Skardi",
                "Skeggi",
                "Skialg",
                "Skidi",
                "Skjaldulf",
                "Skœdir",
                "Skorri",
                "Skuld",
                "Skuld",
                "Skuli",
                "Skur",
                "Slode",
                "Slodi",
                "Snæbjorn",
                "Snorri",
                "Sokkolf",
                "Solmund",
                "Solveig",
                "Spiallbudi",
                "Spiut",
                "Spjut",
                "Spuiti",
                "Stækar",
                "Starkad",
                "Starolf",
                "Stein",
                "Steinar",
                "Steinbjorn",
                "Steingrim",
                "Steinkel",
                "Steinolf",
                "Steinthor",
                "Steinunn",
                "Steinvor",
                "Stigandi",
                "Stuf",
                "Sturla",
                "Styr",
                "Styrbiorn",
                "Styrkar",
                "Styrlaug",
                "Styrmir",
                "Sumarlid",
                "Surt",
                "Svæin",
                "Svala",
                "Svan",
                "Svart",
                "Svein",
                "Sven",
                "Sveni",
                "Sveni",
                "Sverting",
                "Svipday",
                "Thangbrand",
                "Thialfi",
                "Thidrandi",
                "Thiodolf",
                "Thjodhild",
                "Thjodoft",
                "Thjostolf",
                "Thkatla",
                "Thora",
                "Thorald",
                "Thorarin",
                "Thorberg",
                "Thorbjorg",
                "Thorbjorn",
                "Thorbrand",
                "Thord",
                "Thordis",
                "Thorfast",
                "Thorfinn",
                "Thorfinna",
                "Thorfrid",
                "Thorgærd",
                "Thorgeir",
                "Thorgerd",
                "Thorgest",
                "Thorgils",
                "Thorgot",
                "Thorgrim",
                "Thorgrima",
                "Thorgunna",
                "Thorhall",
                "Thorhalla",
                "Thorhild",
                "Thorir",
                "Thorkel",
                "Thorkell",
                "Thorlak",
                "Thorlaug",
                "Thorleif",
                "Thorleik",
                "Thormar",
                "Thormod",
                "Thoroard",
                "Thorod",
                "Thorodd",
                "Thorolf",
                "Thororm",
                "Thorstar",
                "Thorstein",
                "Thorunn",
                "Thorvald",
                "Thorvard",
                "Thrain",
                "Thrand",
                "Throst",
                "Þuriðr",
                "Thyre",
                "Tjorvi",
                "Tofa",
                "Toki",
                "Tola",
                "Tonna",
                "Tore",
                "Torfi",
                "Torgärd",
                "Torrad",
                "Torsten",
                "Tosti",
                "Trud",
                "Tryggvi",
                "Tufi",
                "Ulf",
                "Ulfar",
                "Ulfeid",
                "Ulfrik",
                "Ulvkil",
                "Unn",
                "Unn",
                "Valgard",
                "Valgerd",
                "Vali",
                "Valthjof",
                "Vandrad",
                "Var",
                "Vargas",
                "Varin",
                "Värmod",
                "Vekel",
                "Veleif",
                "Vermund",
                "Vestar",
                "Vifil",
                "Vifil",
                "Vigdis",
                "Vigfus",
                "Vigi",
                "Visäte",
                "Vog",
                "Vott",
                "Waltheof",
                "Wary",
                "White",
                "Yngvar",
                "Yngvild",
                "Yrsa",
            };
            _names = new MarkovNameGenerator(seeds, 3, 2);
        }

        protected override void InitialiseDomains()
        {
            _domains = new[]
            {
                "garðaríki.com",
                "fólkvangr.com",
                "vinland.com",
                "fyrkat.com",
                "valhalla.com",
                "valhöll.com",
                "Ásgarðr.com",
                "asgard.com",
                "Þrúðvangr.com",
                "thrudvang.com",
                "neorxnawang.com",
                "gimlé.com",
                "garðaríki.com",
            };
        }
    }
}