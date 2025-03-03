using System;
using System.Linq;
using System.Text.RegularExpressions;
using Randomator.Data;
using Randomator.Models.Data;

namespace Randomator
{

    public class RandomPhone
    {

        public RandomPhoneType PhoneType { get; set; }
        public string Display { get; set; }

        private Location LocationCountry { get; set; }
        private LocationCity LocationCity { get; set; }
        private LocationArea LocationArea { get ; set;}

        public RandomPhone(RandomPhoneType Type, string Country=null, string City=null)
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

            // Location City
            if(City is null)
            {
                this.LocationCity = Random.Shared.GetItems(LocationCountry.Cities.ToArray(), 1).First();;
            }
            else
            {

                this.LocationCity = this.LocationCountry.Cities.FirstOrDefault(city => city.City == City);

                if(this.LocationCity==null) throw new Exception($"City does not exist in data set: {City}, {Country}");
            }

            this.PhoneType = Type;

            // Get the appropriate format

            this.BuildPhone();

        }

        private void BuildPhone()
        {

            PhoneFormat PhoneFormat = this.LocationCountry.PhoneFormat;

            if(PhoneFormat!=null)
            {
                string[] Formats = null;

                // determine which phone number to generate
                if(this.PhoneType==RandomPhoneType.Land) Formats = PhoneFormat.Land;
                if(this.PhoneType==RandomPhoneType.Mobile) Formats = PhoneFormat.Mobile;

                // select a random format
                string Format = Random.Shared.GetItems(Formats, 1).First();

                // generate format
                Format = Format.Replace("%citycode%",this.LocationCity.PhoneCode);
                Format = Format.Replace("%areacode%",this.LocationCity.PhoneCode);

                // use regex match to replace each %n% with unique number
                Format = Regex.Replace(Format, @"#", (m) => Random.Shared.Next(9).ToString());

                this.Display = Format;
            }

        }

        public override string ToString()
        {

            return this.Display;

        }

    }

    public enum RandomPhoneType
    {
        Land=1,
        Mobile=2
    }
}
