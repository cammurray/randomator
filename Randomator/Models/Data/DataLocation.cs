using System.Collections.Generic;

namespace Randomator.Models.Data
{

    public class Location
    {
        /// <summary>
        /// Country for location
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// Two letter country code
        /// </summary>
        public string CountryCode { get; set; }
        /// <summary>
        /// Location sensitive phone format, with # as placeholders for numbers
        /// </summary>
        public PhoneFormat PhoneFormat { get; set; }
        /// <summary>
        /// City
        /// </summary>
        public List<LocationCity> Cities { get; set; }
        /// <summary>
        /// Location sensitive address format, with variable placeholders
        /// </summary>
        public string[] AddressFormat { get; set; }
        /// <summary>
        /// Name origins, e.g English, French
        /// </summary>
        public string[] NameOrigin { get; set; }
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
