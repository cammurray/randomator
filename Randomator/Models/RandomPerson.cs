using System.Linq;
using Randomator.Data;
using Randomator.Factories.Role;
using Randomator.Models.Data;

namespace Randomator
{

    public class RandomPerson
    {
        public RandomName Name { get; set; }

        public RandomLocation LocationHome { get; set; }
        public RandomLocation LocationWork { get; set; }

        public RandomPhone PhoneHome { get; set; }
        public RandomPhone PhoneWork { get; set; }

        public RandomPhone PhoneMobile { get; set; }
        
        public RandomRole Role { get; set; }

        public RandomPerson(string Country=null)
        {
            // Home location 
            this.LocationHome = new RandomLocation(Country);

            // Get name
            this.Name = new RandomName(this.LocationHome.Country);

            // Work location, in the same city and country as our home
            this.LocationWork = new RandomLocation(this.LocationHome.Country,this.LocationHome.City);

            // Generate phone numbers
            this.PhoneHome = new RandomPhone(RandomPhoneType.Land, this.LocationHome.Country,this.LocationHome.City);
            this.PhoneWork = new RandomPhone(RandomPhoneType.Land, this.LocationHome.Country,this.LocationHome.City);
            this.PhoneMobile = new RandomPhone(RandomPhoneType.Mobile, this.LocationHome.Country,this.LocationHome.City);
            this.Role = factoryRole.Generate();

        }

    }
}
