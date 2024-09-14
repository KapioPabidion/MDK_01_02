using System;

namespace GeneratorDistanceOfTarget
{
    public class Distances
    {
        public static int GeneratorDistanceOfTarget(int min, int max)
        {
            if (min > max)
            {
                return -1;
            }

            Random random = new Random();
            int randomNumber;

            do
            {
                randomNumber = random.Next(min, max + 1);
            }
            while (randomNumber < min || randomNumber > max);

            return randomNumber;
        }
    }
}