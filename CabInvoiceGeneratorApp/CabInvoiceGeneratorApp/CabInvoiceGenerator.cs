namespace CabInvoiceGeneratorApp
{
    public class CabInvoiceGenerator
    {
        private static readonly double COST_PER_KM = 10.0;
        private static readonly double COST_PER_MIN = 1.0;
        private static readonly double MINIMUM_FARE = 5.0;
        private double CabFare = 0.0;
        public double CalculateFare(double Distance, double Time)
        {
            this.CabFare = (Distance * COST_PER_KM) + (Time * COST_PER_MIN);
            return Math.Max(this.CabFare, MINIMUM_FARE);
        }
        public InvoiceSummary GetMultipleRideFare(ModelRide[] rides)
        {
            double Total_Ride_Fare = 0.0;
            foreach (ModelRide data in rides)
            {
                Total_Ride_Fare += this.CalculateFare(data.RideDistance, data.RideTime);
            }
            return new InvoiceSummary(Total_Ride_Fare, rides.Length);
        }
    }
}