using System;

namespace Randomator;

[Flags]
public enum RanCharSet
{
    /// <summary>
    /// All character sets available
    /// </summary>
    All=1,
    
    /// <summary>
    /// Lower case alphabet, a-z
    /// </summary>
    AlphabetLower=2,
    
    /// <summary>
    /// Upper case alphabet, A-Z
    /// </summary>
    AlphabetUpper=4,
    
    /// <summary>
    /// Numbers, 0-9
    /// </summary>
    Numbers=8,
    
    /// <summary>
    /// Special characters, !@#% etc.
    /// </summary>
    SpecialCharacters=16
}