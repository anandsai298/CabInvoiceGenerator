namespace CabInvoiceGeneratorApp
{
    public class InvoiceGenerator
    {
        private static readonly double COST_PER_KM = 10.0;
        private static readonly double COST_PER_MIN = 1.0;
        private static readonly double MINIMUM_FARE = 5.0;
        private double CabFare = 0.0;
        public double CalculateFare(double Distance,double Time)
        {
            this.CabFare = (Distance* COST_PER_KM)+(Time* COST_PER_MIN);
            return Math.Max(this.CabFare, MINIMUM_FARE);
        }
    }
}