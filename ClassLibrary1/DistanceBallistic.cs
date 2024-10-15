using System;

namespace BallisticCalculation
{
    public class BallisticTrajectory
    {
        private double deltaTime = 0.1;
        private double maxTime = 90.0;
        private int numSteps;

        public BallisticTrajectory(double angleInDegrees, double distance)
        {
            numSteps = (int)(maxTime / deltaTime);
        }

        /// REVIEW. a.boikov. 15/10/2024. Делаем тест на этот метод
        public (double, double) CalculateTrajectory(double angle, double distance)
        {
            double[] x = new double[numSteps];
            double[] y = new double[numSteps];

            for (int i = 0; i < numSteps; i++)
            {
                double time = i * deltaTime;
                x[i] = distance * Math.Cos(angle) * time; // Расчет координаты X
                y[i] = distance * Math.Sin(angle) * time - 0.5 * 9.81 * time * time; // Расчет координаты Y
            }

            return (x[numSteps - 1], y[numSteps - 1]); // Возвращает конечные координаты
        }
    }
}