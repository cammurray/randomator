/*
 * 
 * Code taken from https://github.com/chriscore/MarkovSharp/
 * 
 * Base code by Chris Core. MIT License, see LICENSE file.
 * 
 * Modifications have been made for Randomator.
 *
 */
 
namespace MarkovSharp.Models
{
    public class NgramStatistic<TNgram>
    {
        public TNgram Value { get; set; }
        public double Count { get; set; }
        public double Probability { get; set; }
    }
}
