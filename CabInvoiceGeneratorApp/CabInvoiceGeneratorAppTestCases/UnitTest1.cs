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
        [Test]
        public void GivenCalculateMultipleRideFare_WhenAnalyse_ShouldReturnAgreggateFare()
        {
            ModelRide[] data = { new ModelRide(2.0, 5.0), new ModelRide(3.0, 5.0) };
            InvoiceSummary res = this.cabInvoiceGenerator.GetMultipleRideFare(data);
            Assert.AreEqual(60.0, res.TotalFare);
        }
        [Test]
        public void GivenCalculateMultipleRideFare_WhenAnalyse_ShouldReturnAverageFare()
        {
            ModelRide[] data = { new ModelRide(2.0, 5.0), new ModelRide(3.0, 5.0) };
            InvoiceSummary res = this.cabInvoiceGenerator.GetMultipleRideFare(data);
            Assert.AreEqual(30.0, res.AvgFare);
        }
        [Test]
        public void GivenCalculateMultipleRideFare_WhenAnalyse_ShouldReturnNoOfRides()
        {
            ModelRide[] data = { new ModelRide(2.0, 5.0), new ModelRide(3.0, 5.0) };
            InvoiceSummary res = this.cabInvoiceGenerator.GetMultipleRideFare(data);
            Assert.AreEqual(2, res.No_Of_Rides);
        }
    }
}