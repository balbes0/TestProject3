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
            CollectionAssert.AreEqual(testDigits, digits, "��������� �� �����");
        }

        [TestMethod]
        public void AreEqualFail()
        {
            List<int> testDigits = new List<int> { 1, 2, 3, 4 };
            CollectionAssert.AreEqual(testDigits, digits, "��������� �� �����");
        }

        [TestMethod]
        public void AreEquivalentPass()
        {
            List<int> testDigits = new List<int> { 4, 2, 5, 1, 3 };

            CollectionAssert.AreEquivalent(testDigits, digits, "� ���������� ������������ ��������");
        }

        [TestMethod]
        public void AreEquivalentFail()
        {
            List<int> testDigits = new List<int> { 4, 2, 5, 1 };

            CollectionAssert.AreEquivalent(testDigits, digits, "� ���������� ������������ ��������");
        }

        [TestMethod]
        public void LastTestPass()
        {
            double delta = 0.0001; //������� �� ����� ��� ...
            double result = calculate(77, 142); //��� ��������� ����� 
            double trueResult = 54.2254; //��������� �� �������� ����� 54,22535211267606

            Assert.AreEqual(result, trueResult, delta, "������� ������ ����������� ��������");
        }

        [TestMethod]
        public void LastTestFail()
        {
            double delta = 0.0001; //������� �� ����� ��� ...
            double result = calculate(77, 142); //��� ��������� ����� 
            double trueResult = 54.2255; //��������� ����������� �� �������� ����� 54,22535211267606

            Assert.AreEqual(result, trueResult, delta, "������� ������ ����������� ��������");
        }

        private static double calculate(double a, double b)
        {
            return (a / b) * 100;
        }
    }
}