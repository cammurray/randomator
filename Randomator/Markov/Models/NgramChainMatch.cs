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
    public class NgramChainMatch<T>
    {
        internal NgramChainMatch(T ngram, bool matches)
        {
            Ngram = ngram;
            MatchesChain = matches;
        }

        public T Ngram { get; }
        public bool MatchesChain { get; }
    }
}
