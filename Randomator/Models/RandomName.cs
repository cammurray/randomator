using System;
using System.Linq;
using System.Text.RegularExpressions;
using Randomator.Data;
using Randomator.Models.Data;

namespace Randomator
{

    public class RandomName
    {

        /// <summary>
        /// Firstname
        /// </summary>
        public string Firstname { get; set; }
        
        /// <summary>
        /// Lastname
        /// </summary>
        public string Lastname { get; set; }
        
        /// <summary>
        /// Country for person
        /// </summary>
        private Location LocationCountry { get; set; }

        public RandomName(string Country=null)
        {

            // Location Country
            if(Country is null)
            {
                LocationCountry = Random.Shared.GetItems(Locations.Data.ToArray(), 1).First();
            }
            else
            {
                this.LocationCountry = Locations.Data.FirstOrDefault(location => location.Country == Country);

                if(this.LocationCountry==null) throw new Exception($"Country does not exist in data set: {Country}");
            }
            // Get random origin from this country
            string RandomOrigin = Random.Shared.GetItems(LocationCountry.NameOrigin, 1).First();

            // Determine if we have name origin for this location
            var NationalityNamesList = Names.NameNationalities.Names.FirstOrDefault(x => x.Origin == RandomOrigin);

            // Validate names list is not null
            if (NationalityNamesList is null)
                throw new ArgumentException($"No name nationalities for name origin {RandomOrigin}");
            
            // Validate firstnames and lastname lengths are not zero
            if(NationalityNamesList.Firstnames.Length == 0)
                throw new ArgumentException($"No firstname nationalities for name origin {RandomOrigin}");
            
            // Validate firstnames and lastname lengths are not zero
            if(NationalityNamesList.Lastnames.Length == 0)
                throw new ArgumentException($"No lastname nationalities for name origin {RandomOrigin}");

            // get random names from both
            Firstname = Random.Shared.GetItems(NationalityNamesList.Firstnames, 1).First();
            Lastname = Random.Shared.GetItems(NationalityNamesList.Lastnames, 1).First();

        }

    }

    public enum RandomNameType
    {
        First=1,
        Last=2
    }
}
