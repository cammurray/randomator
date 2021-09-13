/*
 * 
 * Code taken from https://github.com/chriscore/MarkovSharp/
 * 
 * Base code by Chris Core. MIT License, see LICENSE file.
 * 
 * Modifications have been made for Randomator.
 *
 */
using System.Collections.Generic;
using System.Linq;

namespace Randomator.Markov.Components
{
    public class AlphabeticUnigramSelectorDesc<T> : IUnigramSelector<T>
    {
        public T SelectUnigram(IEnumerable<T> ngrams)
        {
            return ngrams
                .OrderByDescending(a => a)
                .FirstOrDefault();
        }
    }
}
