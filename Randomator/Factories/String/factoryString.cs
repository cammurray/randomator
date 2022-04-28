using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Randomator.Data;

namespace Randomator.Factories;

internal static class factoryString
{
    public static string Generate(int length, RanCharSet CharsToUse)
    {
        string returnData = "";

        // Use all
        if (CharsToUse.HasFlag(RanCharSet.All))
            CharsToUse = RanCharSet.AlphabetLower | RanCharSet.AlphabetUpper | RanCharSet.Numbers |
                         RanCharSet.SpecialCharacters;
        
        // Characters to use
        List<string> Characters = new List<string>();
            
        // Use alphabet
        if (CharsToUse.HasFlag(RanCharSet.AlphabetLower))
            Characters = Characters.Concat(CharacterSet.alphaLower).ToList();

        // Use upper case letters
        if (CharsToUse.HasFlag(RanCharSet.AlphabetUpper))
            Characters = Characters.Concat(CharacterSet.alphaUpper).ToList();
        
        // Use special case
        if (CharsToUse.HasFlag(RanCharSet.SpecialCharacters))
            Characters = Characters.Concat(CharacterSet.special).ToList();
        
        // Use numbers
        if (CharsToUse.HasFlag(RanCharSet.Numbers))
            Characters = Characters.Concat(CharacterSet.numeric).ToList();

        // Get Char Count
        int CharCount = Characters.Count;
        
        // IF no chars, error
        if (CharCount == 0)
            throw new Exception("No character sets selected for random string");
        
        // Loop until length achieved.
        while (returnData.Length < length)
        {
            // Determine range start and range finish based on options
            returnData += Characters.ElementAt(RandomNumberGenerator.GetInt32(0, CharCount));
        }

        return returnData;
    }
}