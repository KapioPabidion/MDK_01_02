using BallisticCalculation;
namespace Testing
{
    [TestClass]
    public class TBalistic
    {

        [TestMethod]
        /// REVIEW. a.boikov. 05/10/2024. В тестовых данных ожидаемых результатов
        /// явно ошибки. Потому что разрешения 4015 не существует.
        /// Т.е. мы должны результаты математических расчётов перевести на px в соответствии с разрешением экрана   
        [DataRow(0, 0)] 
        [DataRow(10, 1395)] 
        [DataRow(25, 3124)]
        [DataRow(40, 4016)]
        [DataRow(50, 4016)]
        [DataRow(75, 2039)]
        [DataRow(85, 708)]
        public void TestBalistic(double angle, int expected)
        {
            var target = new BallisticDistance(angle);
            double actual = target.CalculateBallistic();
            Assert.AreEqual(expected, actual);
        }
    }

}
