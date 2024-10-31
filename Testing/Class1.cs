using Microsoft.VisualStudio.TestTools.UnitTesting;
using BallisticCalculation;

namespace BallisticCalculationTests
{
    [TestClass] // Указывает, что этот класс содержит тесты
    public class BallisticTrajectoryTests
    {
        [TestMethod] // Указывает, что этот метод является тестом
        public void TestCalculateTrajectory_ZeroAngle()
        {
            // Подготовка данных (Arrange)
            var trajectory = new BallisticTrajectory(0, 0);
            double angle = 0; // угол в радианах
            double distance = 100; // произвольное расстояние

            // Выполнение действия (Act)
            var result = trajectory.CalculateTrajectory(angle * Math.PI / 180, distance);

            // Проверка результатов (Assert)
            Assert.AreEqual(0, result.Item2, 0.01, "Координата Y должна быть примерно равна 0 для угла 0 градусов.");
            Assert.AreEqual(0, result.Item1, 0.01, "Координата X должна быть примерно равна 0 для угла 0 градусов.");
        }

        [TestMethod] // Указывает, что этот метод является тестом
        public void TestCalculateTrajectory_45Degrees()
        {
            // Подготовка данных (Arrange)
            var trajectory = new BallisticTrajectory(45, 100);
            double angle = 45; // угол в градусах
            double distance = 100; // произвольное расстояние

            // Выполнение действия (Act)
            var result = trajectory.CalculateTrajectory(angle * Math.PI / 180, distance);

            // Проверка результатов (Assert)
            // Здесь вы можете проверить, что конечные координаты соответствуют ожидаемым значениям
            // В случае 45 градусов, конечные координаты должны быть равны (x, 0) для некоторого x.
            Assert.IsTrue(result.Item1 > 0, "Координата X должна быть положительной.");
            Assert.IsTrue(result.Item2 < 0, "Координата Y должна быть отрицательной из-за силы тяжести.");
        }

        [TestMethod] // Указывает, что этот метод является тестом
        public void TestCalculateTrajectory_90Degrees()
        {
            // Подготовка данных (Arrange)
            var trajectory = new BallisticTrajectory(90, );
            double angle = 90; // угол в градусах
            double distance = ; // произвольное расстояние

            // Выполнение действия (Act)
            var result = trajectory.CalculateTrajectory(angle * Math.PI / 180, distance);

            // Проверка результатов (Assert)
            Assert.AreEqual(0, result.Item1, 0.01, "Координата X должна быть примерно равна 0 для угла 90 градусов.");
            Assert.IsTrue(result.Item2 > 0, "Координата Y должна быть положительной для угла 90 градусов.");
        }
    }
}
