using System.Collections.Generic;
using Randomator.Models.Data;

/*

    Contains static data, this information could be fetched in a serialized format from JSON too.

    International phone prefixes: https://en.wikipedia.org/wiki/List_of_mobile_telephone_prefixes_by_country 

*/



namespace Randomator.Data
{

    public static class Locations
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
                CountryCode="USA",
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
                CountryCode="UK",
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
                CountryCode="HN",
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
            new Location()                                      // France
            {
                Country="France",
                CountryCode="33",
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
            }
        };

    }
}
