using System.Collections.Generic;

namespace Randomator.Models.Data
{

    public class Location
    {
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public PhoneFormat PhoneFormat { get; set; }

        public List<LocationCity> Cities { get; set; }
        public string[] AddressFormat { get; set; }
    }

    public class LocationCity
    {

        public string City { get; set; }
        public string State { get; set; }
        public string StateShort { get; set; }
        public string[] AddressFormat { get; set; }
        public string PhoneCode { get; set; }

        public List<LocationArea> Areas { get; set; }

    }

    public class LocationArea
    {
        public string Name { get; set; }
        public string[] Roads { get; set; }
        public string[] AddressFormat { get; set; }

        public string PhoneCode { get; set; }
        public string PostZip { get; set; }
    }
}
