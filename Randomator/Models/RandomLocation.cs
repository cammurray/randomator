using System;
using System.Linq;
using Randomator.Data;
using Randomator.Models.Data;
using System.Threading;

namespace Randomator
{

    public class RandomLocation
    {
        public string Area { get; set; }

        public string City { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }

        public string[] Address { get; set; }
        public int StreetNumber { get; set; }
        public string Street { get; set; }
        public string State { get; set; }
        public string StateShort { get; set; }
        public string PostZip { get; set; }

        private Location LocationCountry { get; set; }
        private LocationCity LocationCity { get; set; }
        private LocationArea LocationArea { get ; set;}

        public RandomLocation(string Country=null, string City=null)
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

            // Location City
            if(City==null)
            {
                this.LocationCity = this.LocationCountry.Cities.ElementAt(Helpers.RandomNumber(this.LocationCountry.Cities.Count));
            }
            else
            {

                this.LocationCity = this.LocationCountry.Cities.Where(city => city.City == City).FirstOrDefault();

                if(this.LocationCity==null) throw new Exception($"City does not exist in data set: {City}, {Country}");
            }

            // Location Area
            this.LocationArea = this.LocationCity.Areas.ElementAt(Helpers.RandomNumber(this.LocationCity.Areas.Count));

            // Location City

            this.City = this.LocationCity.City;
            this.Country = this.LocationCountry.Country;
            this.CountryCode = this.LocationCountry.CountryCode;
            this.StreetNumber = Helpers.RandomNumber(1000);
            this.Street = this.LocationArea.Roads.ElementAt(Helpers.RandomNumber(LocationArea.Roads.Length));
            this.PostZip = this.LocationArea.PostZip;
            this.State = this.LocationCity.State;
            this.StateShort = this.LocationCity.StateShort;
            this.Area = this.LocationArea.Name;

            // create a street address
            this.Address = this.BuildAddress();


        }

        private string[] BuildAddress()
        {
            string[] AddressFormat = null;

            /*
                Address format precidence
                1. Local area address format
                2. City address format
                3. Country's address format

            */

            if(this.LocationArea.AddressFormat!=null) 
            {
                AddressFormat = this.LocationArea.AddressFormat;
            }

            if(this.LocationArea.AddressFormat==null && this.LocationCity.AddressFormat!=null) 
            {
                AddressFormat = this.LocationCity.AddressFormat;
            }
            if(this.LocationArea.AddressFormat==null && this.LocationCity.AddressFormat==null && this.LocationCountry.AddressFormat != null) 
            {
                AddressFormat = this.LocationCountry.AddressFormat;
            }

            string[] BuiltAddress = new string[AddressFormat.Length];

            // loop through each and replace the variables
            for(var i = 0; i < AddressFormat.Length; i++)
            {
                string Replaced = AddressFormat[i];

                Replaced = Replaced.Replace("%number%", this.StreetNumber.ToString());
                Replaced = Replaced.Replace("%road%", this.Street);
                Replaced = Replaced.Replace("%area%", this.Area);
                Replaced = Replaced.Replace("%city%", this.City);
                Replaced = Replaced.Replace("%stateshort%", this.StateShort);
                Replaced = Replaced.Replace("%state%", this.State);
                Replaced = Replaced.Replace("%country%", this.Country);
                Replaced = Replaced.Replace("%postzip%", this.PostZip);
                
                BuiltAddress[i] = Replaced;
            }


            // finally set the address format
            return BuiltAddress;

        }

        public override string ToString()
        {

            return string.Join(", ", this.Address);
        }

    }
}
