namespace TestProject3
{
    [TestClass]
    public class UnitTest1
    {
        private static List<int> digits;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            digits = new List<int>{ 1, 2, 3, 4, 5};
        }

        [TestMethod]
        public void CollectionAssert_AreEqual_ShouldPass_WhenCollectionsAreIdentical()
        {
            List<int> testDigits = new List<int> { 1, 2, 3, 4, 5 };
            CollectionAssert.AreEqual(testDigits, digits, "Коллекции не равны");
        }

        [TestMethod]
        public void CollectionAssert_AreEqual_ShouldFail_WhenCollectionsDiffer()
        {
            List<int> testDigits = new List<int> { 1, 2, 3, 4 };
            CollectionAssert.AreEqual(testDigits, digits, "Коллекции не равны");
        }

        [TestMethod]
        public void CollectionAssert_AreEquivalent_ShouldPass_WhenCollectionsContainSameElements()
        {
            List<int> testDigits = new List<int> { 4, 2, 5, 1, 3 };
            CollectionAssert.AreEquivalent(testDigits, digits, "В коллекциях неодинаковые элементы");
        }

        [TestMethod]
        public void CollectionAssert_AreEquivalent_ShouldFail_WhenCollectionsContainDifferentElements()
        {
            List<int> testDigits = new List<int> { 4, 2, 5, 1 };
            CollectionAssert.AreEquivalent(testDigits, digits, "В коллекциях неодинаковые элементы");
        }

        [TestMethod]
        public void Assert_AreEqual_ShouldPass_WhenDeltaIsWithinRange()
        {
            double delta = 0.0001;
            double result = calculate(77, 142);
            double trueResult = 54.2254;
            Assert.AreEqual(result, trueResult, delta, "Капутер видимо неправильно посчитал");
        }

        [TestMethod]
        public void Assert_AreEqual_ShouldFail_WhenDeltaExceedsRange()
        {
            double delta = 0.0001;
            double result = calculate(77, 142);
            double trueResult = 54.2255;
            Assert.AreEqual(result, trueResult, delta, "Капутер видимо неправильно посчитал");
        }

        private static double calculate(double a, double b)
        {
            return (a / b) * 100;
        }
    }
}