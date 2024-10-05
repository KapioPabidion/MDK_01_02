using GeneratorDistanceOfTarget;

namespace Testing
{
    [TestClass]
    public class TBalistic
    {

        [TestMethod]
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
                Assert.AreEqual(expected, actual);
        }
    }

}
