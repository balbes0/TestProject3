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
        public void AreEqualPass()
        {
            List<int> testDigits = new List<int> { 1, 2, 3, 4, 5 };
            CollectionAssert.AreEqual(testDigits, digits, "Коллекции не равны");
        }

        [TestMethod]
        public void AreEqualFail()
        {
            List<int> testDigits = new List<int> { 1, 2, 3, 4 };
            CollectionAssert.AreEqual(testDigits, digits, "Коллекции не равны");
        }

        [TestMethod]
        public void AreEquivalentPass()
        {
            List<int> testDigits = new List<int> { 4, 2, 5, 1, 3 };

            CollectionAssert.AreEquivalent(testDigits, digits, "В коллекциях неодинаковые элементы");
        }

        [TestMethod]
        public void AreEquivalentFail()
        {
            List<int> testDigits = new List<int> { 4, 2, 5, 1 };

            CollectionAssert.AreEquivalent(testDigits, digits, "В коллекциях неодинаковые элементы");
        }

        [TestMethod]
        public void LastTestPass()
        {
            double delta = 0.0001; //разница не более чем ...
            double result = calculate(77, 142); //два рандомных числа 
            double trueResult = 54.2254; //округлили до тысячных число 54,22535211267606

            Assert.AreEqual(result, trueResult, delta, "Капутер видимо неправильно посчитал");
        }

        [TestMethod]
        public void LastTestFail()
        {
            double delta = 0.0001; //разница не более чем ...
            double result = calculate(77, 142); //два рандомных числа 
            double trueResult = 54.2255; //округлили неправильно до тысячных число 54,22535211267606

            Assert.AreEqual(result, trueResult, delta, "Капутер видимо неправильно посчитал");
        }

        private static double calculate(double a, double b)
        {
            return (a / b) * 100;
        }
    }
}