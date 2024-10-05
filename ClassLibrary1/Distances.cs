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

        public double CalculateBallistic(double angle)
        {
            angle = angle * 3.14 / 180;

            double time = 0.0;
            double deltaTime = 0.1;
            double maxTime = 90.0; 

            int numSteps = (int)(maxTime / deltaTime);
            double[] x = new double[numSteps];
            double[] y = new double[numSteps];

            for (int i = 0; i < numSteps; i++)
            {
                time = i * deltaTime;
                double distance = Math.Floor((Math.Pow(shell, 2) * Math.Sin(2 * angle)) / gravity + 0.5);
                x[i] = distance * Math.Cos(angle);
                y[i] = distance * Math.Sin(angle) - 0.5 * gravity * time * time;
            }

            return Distance;
        }
    }
}