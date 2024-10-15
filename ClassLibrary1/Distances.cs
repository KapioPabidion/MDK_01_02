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

            int randomNumber = random.Next(min, max + 1);
            return randomNumber;
        }
    }
}

          