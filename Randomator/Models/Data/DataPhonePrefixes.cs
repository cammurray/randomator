namespace Randomator.Models.Data
{

    public class PhoneFormat
    {

        // Both Mobile and Land are arrays, as the country may have different formats / lack good standards.
        public string[] Mobile { get; set; }
        public string[] Land { get; set; }

    }
}
