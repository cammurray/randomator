using System.Collections.Generic;

namespace Randomator.Models.Data
{
    /// <summary>
    /// Library of Names 
    /// </summary>
    public class NameNationality
    {
        /// <summary>
        /// List of firstnames
        /// </summary>
        public string[] Firstnames { get; set; }
        
        /// <summary>
        /// List of last names
        /// </summary>
        public string[] Lastnames { get; set; }
        
        /// <summary>
        /// Nationality origin
        /// </summary>
        public string Origin { get; set; }
    }

}
