using System.Linq;
using Randomator.Data;
using Randomator.Markov.TokenisationStrategies;

namespace Randomator
{

    public class RandomSentence
    {

        private readonly StringMarkov StringMarkov;

        public RandomSentence()
        {

            // Tran data
            StringMarkov = new StringMarkov(1);

            StringMarkov.Learn(Sentences.Data);

        }

        public string Generate()
        {
            return StringMarkov.Walk().First();
        }

    }

}
