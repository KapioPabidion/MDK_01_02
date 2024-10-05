using GeneratorDistanceOfTarget;

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
        [DataRow(10, 1394)] 
        [DataRow(25, 3122)]
        [DataRow(40, 4015)]
        [DataRow(50, 4016)]
        [DataRow(75, 2043)]
        [DataRow(85, 714)]
        public void TestBalistic(double angle, int expected)
        {
                var target = new Ballistic();
                double actual = target.CalculateBallistic(angle);
            /// REVIEW. a.boikov. 05/10/2024. Тест тест здесь не проходит
            /// CalculateBallistic выдает всегда один и тот же ответ, хотя должна выдавать разный в завсисимости от angle.
            Assert.AreEqual(expected, actual);
        }
    }

}
