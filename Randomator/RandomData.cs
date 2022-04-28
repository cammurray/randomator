using Randomator.Factories;

namespace Randomator;

public static class RandomData
{
    /// <summary>
    /// Returns a random string
    /// </summary>
    /// <param name="length">Length of string to generate</param>
    /// <returns>Random string</returns>
    public static string GenerateString(int length) => factoryString.Generate(length, RanCharSet.All);
    
    /// <summary>
    /// Returns a random string
    /// </summary>
    /// <param name="length">Length of string to generate</param>
    /// <param name="CharSet">Character sets to include</param>
    /// <returns>Random string</returns>
    public static string GenerateString(int length, RanCharSet CharSet) => factoryString.Generate(length, CharSet);

    /// <summary>
    /// Returns a random sentence
    /// </summary>
    /// <returns>Random sentence</returns>
    public static string GenerateSentence()
    {
        RandomSentence RandomSentence = new RandomSentence();

        return RandomSentence.Generate();
    }

    /// <summary>
    /// Returns a random person
    /// </summary>
    /// <param name="Country">Country the person is based</param>
    /// <returns></returns>
    public static RandomPerson GeneratePerson(string? Country)
    {
        RandomPerson RandomPerson = new RandomPerson(Country);

        return RandomPerson;
    }
}