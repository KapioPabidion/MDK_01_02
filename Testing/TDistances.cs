using GeneratorDistanceOfTarget;

namespace Testing
{
    [TestClass]
    public class TDistances
    {
        [TestMethod]
        public void TestGeneratorDistanceOfTarget()
        {
            int min = 300;
            int max = 2000;

            int random = Distances.GeneratorDistanceOfTarget(min, max);

            Assert.IsTrue(min <= random && random <= max);

            min = 1;
            max = 1;

            random = Distances.GeneratorDistanceOfTarget(min, max);

            Assert.AreEqual(1, random);

            min = 2;
            max = 1;

            int randomNumber = Distances.GeneratorDistanceOfTarget(min, max);

            Assert.AreEqual(-1, randomNumber);
        }
    }
}