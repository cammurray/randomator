using System.Collections.Generic;
using Randomator.Models.Data;

/*

    Contains static data, this information could be fetched in a serialized format from JSON too.

    International phone prefixes: https://en.wikipedia.org/wiki/List_of_mobile_telephone_prefixes_by_country 

*/



namespace Randomator.Data
{

    /// <summary>
    /// Contains data for locations
    /// </summary>
    internal static class Locations
    {

        // Locations
        public static readonly List<Location> Data = new List<Location>()
        {
            // Australia
            new Location()
            {
                Country="Australia",
                CountryCode="AU",
                NameOrigin=new string[] {
                    "English"
                },
                PhoneFormat=new PhoneFormat() {
                    Mobile=new string[] {
                       "+61 4### ### ###"
                    },
                    Land=new string[] {
                        "+61 %areacode% #### ####"
                    }
                },
                AddressFormat=new string[] {
                    "%number% %road%",
                    "%city%, %state%",
                    "%country%"
                },
                Cities = new List<LocationCity>()
                {
                    new LocationCity()
                    {
                        City = "Sydney",
                        State = "New South Wales",
                        StateShort = "NSW",
                        PhoneCode = "02",
                        Areas = new List<LocationArea>()
                        {
                            new LocationArea()
                            {
                                Name = "Sydney CBD",
                                PostZip = "2000",
                                Roads = new string[]
                                {
                                    "Oxford Street",
                                    "Hunter Street",
                                    "Elizabeth Street",
                                    "Pitt Street",
                                    "Castlereagh Street",
                                    "Wynyard Lane",
                                    "Macquarie Street"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Bondi",
                                PostZip = "2026",
                                Roads = new string[]
                                {
                                    "Campbell Parade",
                                    "Bondi Road",
                                    "Curlewis Street",
                                    "Hall Street",
                                    "Glenayr Avenue"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Manly",
                                PostZip = "2095",
                                Roads = new string[]
                                {
                                    "The Corso",
                                    "Manly Wharf",
                                    "North Steyne",
                                    "Pittwater Road",
                                    "Darley Road"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Parramatta",
                                PostZip = "2150",
                                Roads = new string[]
                                {
                                    "Church Street",
                                    "Macquarie Street",
                                    "George Street",
                                    "O'Connell Street",
                                    "Smith Street"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Surry Hills",
                                PostZip = "2010",
                                Roads = new string[]
                                {
                                    "Crown Street",
                                    "Foveaux Street",
                                    "Albion Street",
                                    "Bourke Street",
                                    "Devonshire Street"
                                }
                            }
                        }
                    },
                    new LocationCity()
                    {
                        City = "Melbourne",
                        State = "Victoria",
                        StateShort = "VIC",
                        PhoneCode = "03",
                        Areas = new List<LocationArea>()
                        {
                            new LocationArea()
                            {
                                Name = "Melbourne CBD",
                                PostZip = "3000",
                                Roads = new string[]
                                {
                                    "Lonsdale Street",
                                    "Flinders Lane",
                                    "Collins Street",
                                    "Exhibition Street",
                                    "La Trobe Street",
                                    "Finders Street",
                                    "William Street"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "St Kilda",
                                PostZip = "3182",
                                Roads = new string[]
                                {
                                    "Acland Street",
                                    "Fitzroy Street",
                                    "The Esplanade",
                                    "Inkerman Street",
                                    "Barkly Street"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "South Yarra",
                                PostZip = "3141",
                                Roads = new string[]
                                {
                                    "Chapel Street",
                                    "Toorak Road",
                                    "Domain Road",
                                    "Malvern Road",
                                    "Williams Road"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Carlton",
                                PostZip = "3053",
                                Roads = new string[]
                                {
                                    "Lygon Street",
                                    "Elgin Street",
                                    "Drummond Street",
                                    "Faraday Street",
                                    "Cardigan Street"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Richmond",
                                PostZip = "3121",
                                Roads = new string[]
                                {
                                    "Bridge Road",
                                    "Swan Street",
                                    "Church Street",
                                    "Victoria Street",
                                    "Burnley Street"
                                }
                            }
                        }
                    },
                    new LocationCity()
                    {
                        City = "Brisbane",
                        State = "Queensland",
                        StateShort = "QLD",
                        PhoneCode = "07",
                        Areas = new List<LocationArea>()
                        {
                            new LocationArea()
                            {
                                Name = "Brisbane CBD",
                                PostZip = "4000",
                                Roads = new string[]
                                {
                                    "Queen Street",
                                    "Ann Street",
                                    "Adelaide Street",
                                    "George Street",
                                    "Elizabeth Street"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Fortitude Valley",
                                PostZip = "4006",
                                Roads = new string[]
                                {
                                    "Brunswick Street",
                                    "Wickham Street",
                                    "Ann Street",
                                    "Constance Street",
                                    "James Street"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "South Bank",
                                PostZip = "4101",
                                Roads = new string[]
                                {
                                    "Grey Street",
                                    "Stanley Street",
                                    "Little Stanley Street",
                                    "Merivale Street",
                                    "Vulture Street"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "New Farm",
                                PostZip = "4005",
                                Roads = new string[]
                                {
                                    "Brunswick Street",
                                    "Merthyr Road",
                                    "New Farm Park",
                                    "Sydney Street",
                                    "Lambert Street"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Paddington",
                                PostZip = "4064",
                                Roads = new string[]
                                {
                                    "Latrobe Terrace",
                                    "Given Terrace",
                                    "Caxton Street",
                                    "Ithaca Road",
                                    "Rosalie Street"
                                }
                            }
                        }
                    },
                    new LocationCity()
                    {
                        City = "Perth",
                        State = "Western Australia",
                        StateShort = "WA",
                        PhoneCode = "08",
                        Areas = new List<LocationArea>()
                        {
                            new LocationArea()
                            {
                                Name = "Perth CBD",
                                PostZip = "6000",
                                Roads = new string[]
                                {
                                    "St Georges Terrace",
                                    "Hay Street",
                                    "Murray Street",
                                    "William Street",
                                    "Barrack Street"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Fremantle",
                                PostZip = "6160",
                                Roads = new string[]
                                {
                                    "South Terrace",
                                    "High Street",
                                    "Cantonment Street",
                                    "Queen Street",
                                    "Ellen Street"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Subiaco",
                                PostZip = "6008",
                                Roads = new string[]
                                {
                                    "Rokeby Road",
                                    "Hay Street",
                                    "Bagot Road",
                                    "Roberts Road",
                                    "Railway Road"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Cottesloe",
                                PostZip = "6011",
                                Roads = new string[]
                                {
                                    "Marine Parade",
                                    "Napier Street",
                                    "Eric Street",
                                    "Grant Street",
                                    "Railway Street"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Scarborough",
                                PostZip = "6019",
                                Roads = new string[]
                                {
                                    "The Esplanade",
                                    "Scarborough Beach Road",
                                    "Brighton Road",
                                    "West Coast Highway",
                                    "Hastings Street"
                                }
                            }
                        }
                    }
                }
            }, 
            // Brazil
            new Location()
            {
                Country="Brazil",
                CountryCode="BR",
                NameOrigin=new string[] {
                    "Portuguese"
                },
                PhoneFormat=new PhoneFormat() {
                    Mobile=new string[] {
                        "+55 9#### ####"
                    },
                    Land=new string[] {
                        "+55 %areacode% ####-####"
                    }
                },
                AddressFormat=new string[] {
                    "%road%, %number%",
                    "%city% - %state%",
                    "%postzip%",
                    "%country%"
                },
                Cities=new List<LocationCity>(){
                    new LocationCity() {
                        City="São Paulo",
                        State="São Paulo",
                        StateShort="SP",
                        PhoneCode="11",
                        Areas=new List<LocationArea>() {
                            new LocationArea() {
                                Name="São Paulo",
                                PostZip="01000-000",
                                Roads=new string[]{
                                    "Avenida Paulista",
                                    "Rua da Consolação",
                                    "Rua Augusta",
                                    "Avenida Rebouças",
                                    "Rua Haddock Lobo"
                                }
                            }
                        }
                    },
                    new LocationCity() {
                        City="Rio de Janeiro",
                        State="Rio de Janeiro",
                        StateShort="RJ",
                        PhoneCode="21",
                        Areas=new List<LocationArea>() {
                            new LocationArea() {
                                Name="Rio de Janeiro",
                                PostZip="20000-000",
                                Roads=new string[]{
                                    "Avenida Atlântica",
                                    "Rua Barata Ribeiro",
                                    "Avenida Rio Branco",
                                    "Avenida Presidente Vargas",
                                    "Rua São Clemente"
                                }
                            }
                        }
                    }
                }
            },
            // Canada
            new Location()
            {
                Country = "Canada",
                CountryCode = "CA",
                NameOrigin = new string[] {
                    "English",
                    "French"
                },
                PhoneFormat = new PhoneFormat() {
                    Mobile = new string[] {
                        "+1 (%areacode%) ###-####"
                    },
                    Land = new string[] {
                        "+1 (%areacode%) ###-####"
                    }
                },
                AddressFormat = new string[] {
                    "%number% %road%",
                    "%city%, %province% %postzip%",
                    "%country%"
                },
                Cities = new List<LocationCity>(){
                    new LocationCity() {
                        City = "Toronto",
                        State = "Ontario",
                        PhoneCode = "416",
                        Areas = new List<LocationArea>() {
                            new LocationArea() {
                                Name = "Downtown",
                                PostZip = "M5H",
                                Roads = new string[]{
                                    "Bay Street",
                                    "King Street W",
                                    "Queen Street W",
                                    "Yonge Street",
                                    "University Avenue",
                                    "Front Street W"
                                }
                            }
                        }
                    },
                    new LocationCity() {
                        City = "Vancouver",
                        State = "British Columbia",
                        PhoneCode = "604",
                        Areas = new List<LocationArea>() {
                            new LocationArea() {
                                Name = "Downtown",
                                PostZip = "V6B",
                                Roads = new string[]{
                                    "Granville Street",
                                    "Robson Street",
                                    "Burrard Street",
                                    "Hastings Street",
                                    "Pacific Boulevard"
                                }
                            }
                        }
                    },
                    new LocationCity() {
                        City = "Montreal",
                        State = "Quebec",
                        PhoneCode = "514",
                        Areas = new List<LocationArea>() {
                            new LocationArea() {
                                Name = "Old Montreal",
                                PostZip = "H2Y",
                                Roads = new string[]{
                                    "Rue Saint-Paul",
                                    "Rue Saint-Jacques",
                                    "Boulevard Saint-Laurent",
                                    "Rue Notre-Dame",
                                    "Rue Sainte-Catherine"
                                }
                            }
                        }
                    }
                },
            },
            // China
            new Location()
            {
                Country="China",
                CountryCode="CN",
                NameOrigin=new string[] {
                    "Chinese"
                },
                PhoneFormat=new PhoneFormat() {
                    Mobile=new string[] {
                       "+86 136 #### ####",
                       "+86 139 #### ####"
                    },
                    Land=new string[] {
                        "+86 10 #### ####"
                    }
                },
                AddressFormat=new string[] {
                    "%city% %state%",
                    "%road% no %number%",
                    "%country%"
                },
                Cities = new List<LocationCity>(){
                    new LocationCity() {
                        City = "Beijing",
                        State = "Beijing",
                        StateShort = "BJ",
                        PhoneCode = "010",
                        Areas = new List<LocationArea>() {
                            new LocationArea() {
                                Name = "Chaoyang",
                                PostZip = "100022",
                                Roads = new string[]{
                                    "Jianguo Road",
                                    "East Third Ring Road",
                                    "Chaoyang Road",
                                    "Tianshuiyuan Street",
                                    "Jintai Road"
                                }
                            }
                        }
                    },
                    new LocationCity() {
                        City = "Shanghai",
                        State = "Shanghai",
                        StateShort = "SH",
                        PhoneCode = "021",
                        Areas = new List<LocationArea>() {
                            new LocationArea() {
                                Name = "Pudong",
                                PostZip = "200120",
                                Roads = new string[]{
                                    "Century Avenue",
                                    "Lujiazui Ring Road",
                                    "Dongfang Road",
                                    "Yuanshen Road",
                                    "Shiji Dadao"
                                }
                            }
                        }
                    },
                    new LocationCity() {
                        City = "Guangzhou",
                        State = "Guangdong",
                        StateShort = "GD",
                        PhoneCode = "020",
                        Areas = new List<LocationArea>() {
                            new LocationArea() {
                                Name = "Tianhe",
                                PostZip = "510620",
                                Roads = new string[]{
                                    "Tianhe Road",
                                    "Zhujiang New Town",
                                    "Huangpu Avenue",
                                    "Longkou East Road",
                                    "Linhe West Road"
                                }
                            }
                        }
                    }
                }
            },
            // France
            new Location()                                      
            {
                Country="France",
                CountryCode="FR",
                NameOrigin=new string[] {
                    "French"
                },
                PhoneFormat=new PhoneFormat() {
                    Mobile=new string[] {
                        "+36 20 ### ####"
                    },
                    Land=new string[] {
                        "+36 %areacode% ### ####"
                    }
                },
                AddressFormat=new string[] {
                    "%number% %road%",
                    "%postzip% %city%",
                    "%country%"
                },
                Cities=new List<LocationCity>(){
                    new LocationCity() {
                        City="Paris",
                        PhoneCode="1",
                        Areas=new List<LocationArea>() {
                            new LocationArea() {
                                Name="Paris",
                                PostZip="75006",
                                Roads=new string[]{
                                    "Rue de Seine",
                                }
                            },
                            new LocationArea() {
                                Name="Paris",
                                PostZip="75001",
                                Roads=new string[]{
                                    "Rue St Honoré",
                                    "Rue de la Monnaie",
                                    "Quai du Louvre",
                                    "Rue des Prêtres Saint-Germain l'Auxerrois"
                                }
                            },
                            new LocationArea() {
                                Name="Paris",
                                PostZip="75007",
                                Roads=new string[]{
                                    "Quai Voltaire",
                                }
                            },                  
                        }
                    }
                }
            },
            // Germany
            new Location()
            {
                Country = "Germany",
                CountryCode = "DE",
                NameOrigin = new string[] {
                    "German"
                },
                PhoneFormat = new PhoneFormat() {
                    Mobile = new string[] {
                        "+49 0### ### ####"
                    },
                    Land = new string[] {
                        "+49 0%areacode% 000 0000"
                    }
                },
                AddressFormat = new string[] {
                    "%road% %number%",
                    "%postzip% %city%",
                    "%country%"
                },
                Cities = new List<LocationCity>(){
                    new LocationCity() {
                        City = "Berlin",
                        State = "Berlin",
                        StateShort = "BE",
                        PhoneCode = "30",
                        Areas = new List<LocationArea>() {
                            new LocationArea() {
                                Name = "Mitte",
                                PostZip = "10115",
                                Roads = new string[]{
                                    "Unter den Linden",
                                    "Friedrichstraße",
                                    "Alexanderplatz",
                                    "Brandenburg Gate",
                                    "Karl-Liebknecht-Straße",
                                    "Chausseestraße"
                                }
                            }
                        }
                    },
                    new LocationCity() {
                        City = "Munich",
                        State = "Bavaria",
                        StateShort = "BY",
                        PhoneCode = "89",
                        Areas = new List<LocationArea>() {
                            new LocationArea() {
                                Name = "Altstadt-Lehel",
                                PostZip = "80331",
                                Roads = new string[]{
                                    "Marienplatz",
                                    "Kaufingerstraße",
                                    "Sendlinger Straße",
                                    "Tal",
                                    "Viktualienmarkt"
                                }
                            }
                        }
                    },
                    new LocationCity() {
                        City = "Hamburg",
                        State = "Hamburg",
                        StateShort = "HH",
                        PhoneCode = "40",
                        Areas = new List<LocationArea>() {
                            new LocationArea() {
                                Name = "Hamburg-Mitte",
                                PostZip = "20095",
                                Roads = new string[]{
                                    "Reeperbahn",
                                    "Jungfernstieg",
                                    "Spitalerstraße",
                                    "Mönckebergstraße",
                                    "Steinstraße"
                                }
                            }
                        }
                    }
                }
            },
            // Hungary
            new Location()                                      
            {
                Country="Hungary",
                CountryCode="HU",
                NameOrigin=new string[] {
                    "Hungarian"
                },
                PhoneFormat=new PhoneFormat() {
                    Mobile=new string[] {
                        "+36 20 ### ####"
                    },
                    Land=new string[] {
                        "+36 %areacode% ### ####"
                    }
                },
                Cities=new List<LocationCity>(){
                    new LocationCity() {
                        City="Budapest",
                        PhoneCode="1",
                        AddressFormat=new string[] {
                            "%city%",
                            "%road% %number%",
                            "%postzip%",
                            "%country%"
                        },
                        Areas=new List<LocationArea>() {
                            new LocationArea() {
                                Name="Lipótváros",
                                PostZip="1007",
                                Roads=new string[]{
                                    "Garibaldi u.",
                                    "Zoltán u.",
                                    "Széchenyi u.",
                                }
                            },
                            new LocationArea() {
                                Name="Víziváros",
                                PostZip="1007",
                                Roads=new string[]{
                                    "Batthyány u.",
                                    "Sztehlo Gábor rkp."
                                }
                            },                    
                        }
                    }
                }
            },
            // India
            new Location()                                      
            {
                Country="India",
                CountryCode="IN",
                NameOrigin=new string[] {
                    "Indian"
                },
                PhoneFormat=new PhoneFormat() {
                    Mobile=new string[] {
                        "+91 10### ####",
                    },
                    Land=new string[] {
                        "+91 %areacode% #### ####"
                    }
                },
                AddressFormat=new string[] {
                    "%number%, %road%",
                    "%city% %postzip%",
                    "%country%"
                },
                Cities=new List<LocationCity>(){
                    new LocationCity() {
                        City="New Delhi",
                        PhoneCode="11",
                        Areas=new List<LocationArea>() {
                            new LocationArea() {
                                Name="New Delhi",
                                PostZip="110045",
                                Roads=new string[]{
                                    "Shershah Road",
                                    "Purana Quila Rd",
                                    "Narwana Rd",
                                    "Sardar Patel Marg"
                                }
                            }               
                        }
                    }
                }
            },
            // Italy
            new Location()
            {
                Country = "Italy",
                CountryCode = "IT",
                NameOrigin = new string[] {
                    "Italian"
                },
                PhoneFormat = new PhoneFormat() {
                    Mobile = new string[] {
                        "+39 331 ### ####",
                        "+39 347 ### ####",
                        "+39 320 ### ####",
                        "+39 351 ### ####",
                    },
                    Land = new string[] {
                        "+39 %areacode% ### ####",
                    }
                },
                AddressFormat = new string[] {
                    "%number% %road%",
                    "%city%, %state% %postzip%",
                    "%country%"
                },
                Cities = new List<LocationCity>(){
                    new LocationCity() {
                        City = "Rome",
                        State = "Lazio",
                        PhoneCode = "06",
                        Areas = new List<LocationArea>() {
                            new LocationArea() {
                                Name = "Centro Storico",
                                PostZip = "00184",
                                Roads = new string[]{
                                    "Via del Corso",
                                    "Via Nazionale",
                                    "Piazza Navona",
                                    "Via dei Fori Imperiali"
                                }
                            },
                            new LocationArea() {
                                Name = "Trastevere",
                                PostZip = "00153",
                                Roads = new string[]{
                                    "Viale di Trastevere",
                                    "Piazza di Santa Maria",
                                    "Via della Scala",
                                    "Via Garibaldi"
                                }
                            }
                        }
                    },
                    new LocationCity() {
                        City = "Milan",
                        State = "Lombardy",
                        PhoneCode = "02",
                        Areas = new List<LocationArea>() {
                            new LocationArea() {
                                Name = "Duomo",
                                PostZip = "20121",
                                Roads = new string[]{
                                    "Corso Vittorio Emanuele II",
                                    "Via Dante",
                                    "Piazza del Duomo",
                                    "Via Torino"
                                }
                            },
                            new LocationArea() {
                                Name = "Brera",
                                PostZip = "20121",
                                Roads = new string[]{
                                    "Via Brera",
                                    "Via Fiori Chiari",
                                    "Via San Marco",
                                    "Via Solferino"
                                }
                            }
                        }
                    },
                    new LocationCity() {
                        City = "Florence",
                        State = "Tuscany",
                        PhoneCode = "055",
                        Areas = new List<LocationArea>() {
                            new LocationArea() {
                                Name = "Centro Storico",
                                PostZip = "50122",
                                Roads = new string[]{
                                    "Via dei Calzaiuoli",
                                    "Via de' Tornabuoni",
                                    "Piazza della Signoria",
                                    "Via della Vigna Nuova"
                                }
                            },
                            new LocationArea() {
                                Name = "San Lorenzo",
                                PostZip = "50123",
                                Roads = new string[]{
                                    "Via San Zanobi",
                                    "Via Faenza",
                                    "Via de' Ginori",
                                    "Via della Stufa"
                                }
                            }
                        }
                    },
                    new LocationCity() {
                        City = "Venice",
                        State = "Veneto",
                        PhoneCode = "041",
                        Areas = new List<LocationArea>() {
                            new LocationArea() {
                                Name = "San Marco",
                                PostZip = "30124",
                                Roads = new string[]{
                                    "Piazza San Marco",
                                    "Calle Larga XXII Marzo",
                                    "Calle del Fumo",
                                    "Salita Fontego"
                                }
                            },
                            new LocationArea() {
                                Name = "Cannaregio",
                                PostZip = "30121",
                                Roads = new string[]{
                                    "Strada Nuova",
                                    "Fondamenta della Misericordia",
                                    "Calle della Madonna",
                                    "Rio Terà della Maddalena"
                                }
                            }
                        }
                    }
                },
            },
            // Japan
            new Location()
            {
                Country = "Japan",
                CountryCode = "JP",
                NameOrigin = new string[]
                {
                    "Nihon"
                },
                PhoneFormat = new PhoneFormat()
                {
                    Mobile = new string[]
                    {
                        "+81 90-####-####",
                        "+81 80-####-####"
                    },
                    Land = new string[]
                    {
                        "+81 %areacode% #### ####"
                    }
                },
                AddressFormat = new string[]
                {
                    "%number% %road%",
                    "%city%, %state%",
                    "%country%"
                },
                Cities = new List<LocationCity>()
                {
                    new LocationCity()
                    {
                        City = "Tokyo",
                        State = "Tokyo",
                        StateShort = "TKY",
                        PhoneCode = "03",
                        Areas = new List<LocationArea>()
                        {
                            new LocationArea()
                            {
                                Name = "Shibuya",
                                PostZip = "150-0001",
                                Roads = new string[]
                                {
                                    "Shibuya Crossing",
                                    "Meiji-dori",
                                    "Omotesando",
                                    "Cat Street"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Shinjuku",
                                PostZip = "160-0022",
                                Roads = new string[]
                                {
                                    "Shinjuku Dori",
                                    "Yasukuni Dori",
                                    "Kabukicho",
                                    "Golden Gai"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Ginza",
                                PostZip = "104-0061",
                                Roads = new string[]
                                {
                                    "Chuo Dori",
                                    "Harumi Dori",
                                    "Namiki Dori",
                                    "Marronnier Dori"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Asakusa",
                                PostZip = "111-0032",
                                Roads = new string[]
                                {
                                    "Nakamise Dori",
                                    "Kaminarimon Dori",
                                    "Denpoin Dori",
                                    "Sumida Park Street"
                                }
                            }
                        }
                    },
                    new LocationCity()
                    {
                        City = "Osaka",
                        State = "Osaka",
                        StateShort = "OSK",
                        PhoneCode = "06",
                        Areas = new List<LocationArea>()
                        {
                            new LocationArea()
                            {
                                Name = "Umeda",
                                PostZip = "530-0001",
                                Roads = new string[]
                                {
                                    "Midosuji",
                                    "Hankyu Higashidori",
                                    "Osaka Loop Line",
                                    "Hep Five"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Namba",
                                PostZip = "542-0076",
                                Roads = new string[]
                                {
                                    "Dotonbori",
                                    "Sennichimae",
                                    "Nansan Dori",
                                    "Ebisubashi-suji"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Tennoji",
                                PostZip = "543-0056",
                                Roads = new string[]
                                {
                                    "Abeno-suji",
                                    "Mio Road",
                                    "Tennoji Park Street",
                                    "Shitennoji Temple Road"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Shinsaibashi",
                                PostZip = "542-0086",
                                Roads = new string[]
                                {
                                    "Shinsaibashi-suji",
                                    "Nagahori Dori",
                                    "Midosuji",
                                    "Amerikamura"
                                }
                            }
                        }
                    },
                    new LocationCity()
                    {
                        City = "Kyoto",
                        State = "Kyoto",
                        StateShort = "KYO",
                        PhoneCode = "075",
                        Areas = new List<LocationArea>()
                        {
                            new LocationArea()
                            {
                                Name = "Gion",
                                PostZip = "605-0074",
                                Roads = new string[]
                                {
                                    "Shijo Dori",
                                    "Hanami-koji",
                                    "Yasaka Shrine Road",
                                    "Miyagawa-cho"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Arashiyama",
                                PostZip = "616-8385",
                                Roads = new string[]
                                {
                                    "Sagano",
                                    "Togetsukyo Bridge",
                                    "Bamboo Grove Path",
                                    "Kiyotaki Dori"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Fushimi",
                                PostZip = "612-0805",
                                Roads = new string[]
                                {
                                    "Fushimi Inari Taisha Road",
                                    "Sake Brewery Street",
                                    "Momoyama Dori",
                                    "Ujigawa Street"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Higashiyama",
                                PostZip = "605-0846",
                                Roads = new string[]
                                {
                                    "Ninenzaka",
                                    "Sannenzaka",
                                    "Yasaka Pagoda Road",
                                    "Chawan-zaka"
                                }
                            }
                        }
                    },
                }
            },
            // USA
            new Location()
            {
                Country="United States of America",
                CountryCode="US",
                NameOrigin=new string[] {
                    "English",
                    "Spanish"
                },
                PhoneFormat=new PhoneFormat() {
                    Mobile=new string[] {
                        "+1 (%areacode%) ###-###"
                    },
                    Land=new string[] {
                        "+1 (%areacode%) ###-####"
                    }
                },
                AddressFormat=new string[] {
                            "%number% %road%",
                            "%city%, %stateshort% %postzip%",
                            "%country%"
                },
                Cities = new List<LocationCity>()
                {
                    new LocationCity()
                    {
                        City = "Seattle",
                        State = "Washington",
                        StateShort = "WA",
                        PhoneCode = "206",
                        Areas = new List<LocationArea>()
                        {
                            new LocationArea()
                            {
                                Name = "Downtown",
                                PostZip = "98101",
                                Roads = new string[]
                                {
                                    "E Pine Street",
                                    "E Pike Street",
                                    "Pike Street",
                                    "3rd Avenue",
                                    "Union Street",
                                    "Columbia Street",
                                    "Elliott Ave",
                                    "Alaskan Way",
                                    "E Madison Street",
                                    "Denny Way"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Ballard",
                                PostZip = "98107",
                                Roads = new string[]
                                {
                                    "NW Market Street",
                                    "Ballard Avenue NW",
                                    "Leary Avenue NW",
                                    "15th Avenue NW",
                                    "24th Avenue NW"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Fremont",
                                PostZip = "98103",
                                Roads = new string[]
                                {
                                    "Fremont Avenue N",
                                    "N 36th Street",
                                    "N 45th Street",
                                    "Stone Way N",
                                    "Aurora Avenue N"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Queen Anne",
                                PostZip = "98109",
                                Roads = new string[]
                                {
                                    "Queen Anne Avenue N",
                                    "Mercer Street",
                                    "Roy Street",
                                    "Dexter Avenue N",
                                    "W McGraw Street"
                                }
                            }
                        }
                    },
                    new LocationCity()
                    {
                        City = "San Francisco",
                        State = "California",
                        StateShort = "CA",
                        PhoneCode = "415",
                        Areas = new List<LocationArea>()
                        {
                            new LocationArea()
                            {
                                Name = "Marina District",
                                PostZip = "94123",
                                Roads = new string[]
                                {
                                    "Buchanan Street",
                                    "Chestnut Street",
                                    "Lombard Street",
                                    "Bay Street",
                                    "Fillmore Street",
                                    "Union Street"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Mission District",
                                PostZip = "94110",
                                Roads = new string[]
                                {
                                    "Mission Street",
                                    "Valencia Street",
                                    "24th Street",
                                    "16th Street",
                                    "Cesar Chavez Street"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Nob Hill",
                                PostZip = "94109",
                                Roads = new string[]
                                {
                                    "California Street",
                                    "Powell Street",
                                    "Bush Street",
                                    "Jones Street",
                                    "Sacramento Street"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Chinatown",
                                PostZip = "94108",
                                Roads = new string[]
                                {
                                    "Grant Avenue",
                                    "Stockton Street",
                                    "Washington Street",
                                    "Clay Street",
                                    "Pacific Avenue"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "SoMa",
                                PostZip = "94103",
                                Roads = new string[]
                                {
                                    "Market Street",
                                    "4th Street",
                                    "Howard Street",
                                    "Harrison Street",
                                    "Folsom Street"
                                }
                            }
                        }
                    },
                    new LocationCity()
                    {
                        City = "New York",
                        State = "New York",
                        StateShort = "NY",
                        PhoneCode = "212",
                        Areas = new List<LocationArea>()
                        {
                            new LocationArea()
                            {
                                Name = "Manhattan",
                                PostZip = "10012",
                                Roads = new string[]
                                {
                                    "W 3rd Street",
                                    "Mott Street",
                                    "5th Avenue",
                                    "E 42nd Street",
                                    "W 16th Street",
                                    "E 6th Street"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Brooklyn",
                                PostZip = "11201",
                                Roads = new string[]
                                {
                                    "Fulton Street",
                                    "Flatbush Avenue",
                                    "Atlantic Avenue",
                                    "Court Street",
                                    "Montague Street"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Queens",
                                PostZip = "11101",
                                Roads = new string[]
                                {
                                    "Queens Boulevard",
                                    "Jackson Avenue",
                                    "Vernon Boulevard",
                                    "21st Street",
                                    "Northern Boulevard"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Bronx",
                                PostZip = "10451",
                                Roads = new string[]
                                {
                                    "Grand Concourse",
                                    "Jerome Avenue",
                                    "E 149th Street",
                                    "E Tremont Avenue",
                                    "Webster Avenue"
                                }
                            },
                            new LocationArea()
                            {
                                Name = "Staten Island",
                                PostZip = "10301",
                                Roads = new string[]
                                {
                                    "Bay Street",
                                    "Richmond Terrace",
                                    "Hylan Boulevard",
                                    "Victory Boulevard",
                                    "Forest Avenue"
                                }
                            }
                        }
                    }
                },
            },
            // UK
            new Location()
            {
                Country="United Kingdom",
                CountryCode="GB",
                NameOrigin=new string[] {
                    "English"
                },
                PhoneFormat=new PhoneFormat() {
                    Mobile=new string[] {
                        "+44 71## ######"
                    },
                    Land=new string[] {
                        "+44 (%areacode%) #### ####"
                    }
                },
                Cities=new List<LocationCity>(){
                    new LocationCity() {
                        City="London",
                        PhoneCode="020",
                        AddressFormat=new string[] {
                                    "%number% %road%",
                                    "%locality%",
                                    "%city%",
                                    "%country%"
                        },
                        Areas=new List<LocationArea>() {
                            new LocationArea() {
                                Name="London",
                                PostZip="EC1A",
                                AddressFormat=new string[] {
                                    "%number% %road%",
                                    "%city%",
                                    "%country%"
                                },
                                Roads=new string[]{
                                    "King William Street",
                                    "Cannon Street",
                                    "Princes Street",
                                    "Threadneedle Street",
                                    "Throgmorton Street",
                                    "Coleman Street"
                                }
                            }
                        }
                    }
                }
            },
            // Poland
            new Location()
            {
                Country = "Poland",
                CountryCode = "PL",
                NameOrigin = new string[] {
                    "Polish"
                },
                PhoneFormat = new PhoneFormat() {
                    Mobile = new string[] {
                        "+48 60# ### ###"
                    },
                    Land = new string[] {
                        "+48 %areacode% ### ####"
                    }
                },
                AddressFormat = new string[] {
                    "%number% %road%",
                    "%city% %postzip%",
                    "%country%"
                },
                Cities = new List<LocationCity>(){
                    new LocationCity() {
                        City = "Warsaw",
                        State = "Masovian",
                        PhoneCode = "22",
                        Areas = new List<LocationArea>() {
                            new LocationArea() {
                                Name = "Śródmieście",
                                PostZip = "00-001",
                                Roads = new string[]{
                                    "ul. Marszałkowska",
                                    "ul. Nowy Świat",
                                    "ul. Krakowskie Przedmieście",
                                    "Al. Jerozolimskie",
                                    "ul. Chmielna"
                                }
                            }
                        }
                    },
                    new LocationCity() {
                        City = "Kraków",
                        State = "Lesser Poland",
                        PhoneCode = "12",
                        Areas = new List<LocationArea>() {
                            new LocationArea() {
                                Name = "Stare Miasto",
                                PostZip = "31-001",
                                Roads = new string[]{
                                    "ul. Floriańska",
                                    "ul. Grodzka",
                                    "ul. Kanonicza",
                                    "ul. Szewska",
                                    "ul. Karmelicka"
                                }
                            }
                        }
                    },
                    new LocationCity() {
                        City = "Gdańsk",
                        State = "Pomeranian",
                        PhoneCode = "58",
                        Areas = new List<LocationArea>() {
                            new LocationArea() {
                                Name = "Śródmieście",
                                PostZip = "80-001",
                                Roads = new string[]{
                                    "ul. Długa",
                                    "ul. Mariacka",
                                    "ul. Świętojańska",
                                    "Targ Węglowy",
                                    "Podwale Przedmiejskie"
                                }
                            }
                        }
                    }
                },
            },
            // South Korea
            new Location()                                      
            {
                Country="South Korea",
                CountryCode="KR",
                NameOrigin=new string[] {
                    "Korean"
                },
                PhoneFormat=new PhoneFormat() {
                    Mobile=new string[] {
                        "+82 10 ### ####",
                        "+82 11 ### ####",
                    },
                    Land=new string[] {
                        "+82 %areacode% ### ####"
                    }
                },
                AddressFormat=new string[] {
                    "%number% %road%",
                    "%area%, %city%",
                    "%country%"
                },
                Cities=new List<LocationCity>(){
                    new LocationCity() {
                        City="Seoul",
                        PhoneCode="2",
                        Areas=new List<LocationArea>() {
                            new LocationArea() {
                                Name="Yongsan-gu",
                                PostZip="043NN",
                                Roads=new string[]{
                                    "Huam-dong",
                                    "Hangangno 2(i)-ga",
                                    "Hangangno-dong",
                                    "Seobinggo-ro 51-gil"
                                }
                            }               
                        }
                    }
                }
            },
            // Singapore
            new Location()
            {
                Country = "Singapore",
                CountryCode = "SG",
                NameOrigin = new string[] {
                    "Malay",
                    "Chinese",
                    "Tamil",
                    "English"
                },
                PhoneFormat = new PhoneFormat() {
                    Mobile = new string[] {
                        "+65 #### ####"
                    },
                    Land = new string[] {
                        "+65 #### ####"
                    }
                },
                AddressFormat = new string[] {
                    "%number% %road%",
                    "%city%",
                    "%country% %postzip%"
                },
                Cities = new List<LocationCity>(){
                    new LocationCity() {
                        City = "Singapore",
                        State = "",
                        StateShort = "",
                        PhoneCode = "65",
                        Areas = new List<LocationArea>() {
                            new LocationArea() {
                                Name = "Central Business District",
                                PostZip = "018960",
                                Roads = new string[]{
                                    "Shenton Way",
                                    "Robinson Road",
                                    "Cecil Street",
                                    "Raffles Quay",
                                    "Marina Boulevard"
                                }
                            },
                            new LocationArea() {
                                Name = "Orchard",
                                PostZip = "238839",
                                Roads = new string[]{
                                    "Orchard Road",
                                    "Scotts Road",
                                    "Tanglin Road",
                                    "Grange Road"
                                }
                            },
                            new LocationArea() {
                                Name = "Bugis",
                                PostZip = "188027",
                                Roads = new string[]{
                                    "Victoria Street",
                                    "Middle Road",
                                    "North Bridge Road",
                                    "Queen Street"
                                }
                            }
                        }
                    }
                },
            },
        };

    }
}
