using GeneratorDistanceOfTarget;

namespace Testing
{
    [TestClass]
    public class TBalistic
    {

        [TestMethod]
        [DataRow(0, 0)] 
        [DataRow(10, 394)] 
        [DataRow(25, 1011)]
        [DataRow(40, 1733)]
        [DataRow(50, 2211)]
        [DataRow(75, 3399)]
        [DataRow(85, 4666)]
        public void TestBalistic(double angle, int expected)
        {
                var target = new Ballistic();
                int actual = target.CalculateBallistic(angle);
                Assert.AreEqual(expected, actual);
        }
    }

}
