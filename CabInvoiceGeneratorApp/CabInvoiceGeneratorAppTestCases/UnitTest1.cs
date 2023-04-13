using CabInvoiceGeneratorApp;

namespace CabInvoiceGeneratorAppTestCases
{
    public class Tests
    {
        private CabInvoiceGenerator cabInvoiceGenerator;
        [SetUp]
        public void Setup()
        {
            this.cabInvoiceGenerator = new CabInvoiceGenerator();
        }

        [Test]
        public void GivenCalculateFare_WhenAnalyse_ShouldReturnFare()
        {
            double res = this.cabInvoiceGenerator.CalculateFare(10, 10);
            Assert.AreEqual(110,res);
        }
        [Test]
        public void GivenCalculateFare_WhenAnalyse_ShouldReturnMinFare()
        {
            double res = this.cabInvoiceGenerator.CalculateFare(0.2, 1);
            Assert.AreEqual(5, res);
        }
    }
}