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

            /// REVIEW. a.boikov. 05/10/2024. Ограничения уже определены в рамках Next
            /// Метод не выдаст данных, выходящих за указанный диапазон гарантированно
            /// Цикл не нужен.
            do
            {
                randomNumber = random.Next(min, max + 1);
            }
            while (randomNumber < min || randomNumber > max);

            return randomNumber;
        }
    }

    /// REVIEW. a.boikov. 05/10/2024. В тестовых данных ожидаемых результатов
    /// явно ошибки. class Ballistic вынести в отдельный файл библиотеки классов
    public class Ballistic
    {
        /// REVIEW. a.boikov. 05/10/2024. добавить комментарий к переменным, что они значат
        private const int shell = 200;
        private const double gravity = 9.81;

        public double CalculateBallistic(double angle)
        {
            angle = angle * 3.14 / 180;

            /// REVIEW. a.boikov. 05/10/2024. Этот метод должен вычислить всего лишь координату падения.
            /// Она состоит из значения X и значения Y.
            /// Цикл не нужен. Обычная формула расчёта координаты падения

            double distance = Math.Floor((Math.Pow(shell, 2) * Math.Sin(2 * angle)) / gravity + 0.5);
            double x = distance * Math.Cos(angle);
            double y = distance * Math.Sin(angle);

            return distance; // return the distance
        }

        public (double, double) CalculateTrajectory(double angle)
        {
            angle = angle * 3.14 / 180;

            double deltaTime = 0.1;
            double maxTime = 90.0;
            int numSteps = (int)(maxTime / deltaTime);

            double[] x = new double[numSteps];
            double[] y = new double[numSteps];

            for (int i = 0; i < numSteps; i++)
            {
                double time = i * deltaTime;
                x[i] = distance * Math.Cos(angle);
                y[i] = distance * Math.Sin(angle) - 0.5 * gravity * time * time;
            }

            return (x[numSteps - 1], y[numSteps - 1]); // return the final x and y coordinates
        }
    }
}