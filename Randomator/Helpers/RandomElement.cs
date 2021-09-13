using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography;

namespace Randomator
{
    internal static class Helpers
    {

        public static string RandomElement(string[] InputData)
        {
            // Verify input data
            if(InputData==null) throw new Exception("No random input data has been given to RandomElement");

            return InputData[RandomNumber(InputData.Length)];

        }

        public static Int32 RandomNumber(int Max)
        {

            /*
                Random.Random() is not Random, it's not thread safe either.

                Use System.Cryptography for a random key, which is then used to create a seed for random
            */

            RNGCryptoServiceProvider rngCryptoServiceProvider = new RNGCryptoServiceProvider();
            byte[] randomBytes = new byte[256];
            rngCryptoServiceProvider.GetBytes(randomBytes);

            Int32 seed = BitConverter.ToInt32(randomBytes,0);

            Random Random = new Random(seed);

            return Random.Next(Max);
        }

    }
}
