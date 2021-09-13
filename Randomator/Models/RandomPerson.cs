using System.Linq;
using Randomator.Data;
using Randomator.Models.Data;

namespace Randomator
{

    public class RandomPerson
    {
        public string Firstname { get ; set; }
        public string Lastname { get; set; }

        public RandomLocation LocationHome { get; set; }
        public RandomLocation LocationWork { get; set; }

        public RandomPhone PhoneHome { get; set; }
        public RandomPhone PhoneWork { get; set; }

        public RandomPhone PhoneMobile { get; set; }

        public RandomPerson()
        {

            // Names
            this.Firstname = Helpers.RandomElement(Names.Firstnames);
            this.Lastname = Helpers.RandomElement(Names.Lastnames);

            // Home location 
            this.LocationHome = new RandomLocation();

            // Work location, in the same city and country as our home
            this.LocationWork = new RandomLocation(this.LocationHome.Country,this.LocationHome.City);

            // Generate phone numbers
            this.PhoneHome = new RandomPhone(RandomPhoneType.Land, this.LocationHome.Country,this.LocationHome.City);
            this.PhoneWork = new RandomPhone(RandomPhoneType.Land, this.LocationHome.Country,this.LocationHome.City);
            this.PhoneMobile = new RandomPhone(RandomPhoneType.Mobile, this.LocationHome.Country,this.LocationHome.City);

        }

    }
}
