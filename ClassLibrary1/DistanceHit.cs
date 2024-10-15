using System;

namespace BallisticCalculation
{
    public class BallisticDistance
    {
        private const int shell = 200; // Начальная скорость снаряда
        private const double gravity = 9.81; // Ускорение свободного падения

        private double angle; // Угол в радианах

        public BallisticDistance(double angleInDegrees)
        {
            angle = angleInDegrees * Math.PI / 180; // Преобразование угла в радианы
        }

        public double CalculateBallistic()
        {
            double distance = Math.Floor((Math.Pow(shell, 2) * Math.Sin(2 * angle)) / gravity + 0.5);
            return distance; // Возвращает дистанцию
        }
    }
}