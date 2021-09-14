using System;
using System.Linq;
using System.Text.RegularExpressions;
using Randomator.Data;
using Randomator.Models.Data;

namespace Randomator
{

    public class RandomName
    {

        public string Firstname { get; set; }
        public string Lastname { get; set; }

        private Location LocationCountry { get; set; }

        public RandomName(string Country=null)
        {

            // Location Country
            if(Country==null)
            {
                this.LocationCountry = Locations.Data.ElementAt(Helpers.RandomNumber(Locations.Data.Count));
            }
            else
            {
                this.LocationCountry = Locations.Data.Where(location => location.Country == Country).FirstOrDefault();

                if(this.LocationCountry==null) throw new Exception($"Country does not exist in data set: {Country}");
            }
            // Get random origin from this country
            string RandomOrigin = Helpers.RandomElement(this.LocationCountry.NameOrigin);



            string[] FirstnameCollection = Names.Firstnames.Where(name => name.Origin == RandomOrigin).First().Name;
            string[] LastnameCollection = Names.Lastnames.Where(name => name.Origin == RandomOrigin).First().Name;

            // If there are none, default to english
            if(FirstnameCollection.Length == 0 || LastnameCollection.Length == 0)
            {
                FirstnameCollection = Names.Firstnames.Where(name => name.Origin == "English").First().Name;
                LastnameCollection = Names.Lastnames.Where(name => name.Origin == "English").First().Name;
            }

            // get random names from both
            this.Firstname = FirstnameCollection[Helpers.RandomNumber(FirstnameCollection.Length)];
            this.Lastname = LastnameCollection[Helpers.RandomNumber(LastnameCollection.Length)];

        }

    }

    public enum RandomNameType
    {
        First=1,
        Last=2
    }
}
