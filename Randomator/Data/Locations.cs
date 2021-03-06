using System.Collections.Generic;
using Randomator.Models.Data;

/*

    Contains static data, this information could be fetched in a serialized format from JSON too.

    International phone prefixes: https://en.wikipedia.org/wiki/List_of_mobile_telephone_prefixes_by_country 

*/



namespace Randomator.Data
{

    internal static class Locations
    {
        /*

            Contains data for Locations

        */

        // Locations
        public static readonly List<Location> Data = new List<Location>()
        {
            new Location()                                      // Australia
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
                Cities=new List<LocationCity>(){
                    new LocationCity() {
                        City="Sydney",
                        State="New South Wales",
                        StateShort="NSW",
                        PhoneCode="08",
                        Areas=new List<LocationArea>() {
                            new LocationArea() {
                                Name="Sydney",
                                PostZip="2000",
                                Roads=new string[]{
                                    "Oxford Street",
                                    "Hunter Street",
                                    "Elizabeth Street",
                                    "Pitt Street",
                                    "Castlerreagh Street",
                                    "Wynyard Lane",
                                    "Macquarie Street"
                                }
                            }
                        }
                    },
                    new LocationCity() {
                        City="Melbourne",
                        State="Victoria",
                        StateShort="VIC",
                        PhoneCode="03",
                        Areas=new List<LocationArea>() {
                            new LocationArea() {
                                Name="Melbourne",
                                PostZip="3000",
                                Roads=new string[]{
                                    "Lonsdale Street",
                                    "Flinders Lane",
                                    "Collins Street",
                                    "Exhibition Street",
                                    "La Trobe Street",
                                    "Finders Street",
                                    "William Street"
                                }
                            }
                        }
                    }
                }
            },
            new Location()                                      // USA
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
                Cities=new List<LocationCity>(){
                    new LocationCity() {
                        City="Seattle",
                        State="Washington",
                        StateShort="WA",
                        PhoneCode="206",
                        Areas=new List<LocationArea>() {
                            new LocationArea() {
                                Name="Seattle",
                                PostZip="98101",
                                Roads=new string[]{
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
                            }
                        }
                    },
                    new LocationCity() {
                        City="San Francisco",
                        State="California",
                        StateShort="CA",
                        PhoneCode="415",
                        Areas=new List<LocationArea>() {
                            new LocationArea() {
                                Name="Marina District",
                                PostZip="94123",
                                Roads=new string[]{
                                    "Buchanan Street",
                                    "Chestnut Street",
                                    "Lombard Street",
                                    "Bay Street",
                                    "Fillmore Street",
                                    "Union Street"
                                }
                            }
                        }
                    },
                    new LocationCity() {
                        City="New York",
                        State="New York",
                        StateShort="NY",
                        PhoneCode="212",
                        Areas=new List<LocationArea>() {
                            new LocationArea() {
                                Name="New York",
                                PostZip="10012",
                                Roads=new string[]{
                                    "W 3rd Street",
                                    "Mott Street",
                                    "5th Avenue",
                                    "E 42nd Street",
                                    "W 16th Street",
                                    "E 6th Street"
                                }
                            }
                        }
                    }
                },
            },
            new Location()                                      // UK
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
            new Location()                                      // Hungary
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
                                Name="Lip??tv??ros",
                                PostZip="1007",
                                Roads=new string[]{
                                    "Garibaldi u.",
                                    "Zolt??n u.",
                                    "Sz??chenyi u.",
                                }
                            },
                            new LocationArea() {
                                Name="V??ziv??ros",
                                PostZip="1007",
                                Roads=new string[]{
                                    "Batthy??ny u.",
                                    "Sztehlo G??bor rkp."
                                }
                            },                    
                        }
                    }
                }
            },
            new Location()                                      // France
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
                                    "Rue St Honor??",
                                    "Rue de la Monnaie",
                                    "Quai du Louvre",
                                    "Rue des Pr??tres Saint-Germain l'Auxerrois"
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
            new Location()                                      // South Korea
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
            new Location()                                      // India
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
        };

    }
}
