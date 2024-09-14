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
    public class Ballistic
    {
        private const int shell = 200; 
        private const double gravity = 9.81;

        public int CalculateBallistic(double angle)
        {
            
            double angleInRadians = angle * Math.PI / 180;

            int distance = (int)(((shell * shell) * Math.Sin(2 * angleInRadians)) / (2 * gravity));

            return distance;
        }
    }
}