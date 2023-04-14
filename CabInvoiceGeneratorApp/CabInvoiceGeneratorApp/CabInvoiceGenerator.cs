namespace CabInvoiceGeneratorApp
{
    public class CabInvoiceGenerator
    {
        RideRespiratory rideRespiratory=new RideRespiratory();
        private static readonly double COST_PER_KM = 10.0;
        private static readonly double COST_PER_MIN = 1.0;
        private static readonly double MINIMUM_FARE = 5.0;
        private double CabFare = 0.0;
        public double CalculateFare(double Distance, double Time)
        {
            this.CabFare = (Distance * COST_PER_KM) + (Time * COST_PER_MIN);
            return Math.Max(this.CabFare, MINIMUM_FARE);
        }
        public double CalculateFare(double CostPerKm,double CostPerMin,double Minimumfare, double Distance, double Time)
        {
            this.CabFare = (Distance * CostPerKm) + (Time * CostPerMin);
            return Math.Max(this.CabFare, Minimumfare);
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
        public void MapRideToUser(string userId, ModelRide[] rides)
        {
            this.rideRespiratory.AddCabRides(userId, rides);
        }
        public InvoiceSummary GetInvoiceSummary(string userId)
        {
            return this.GetMultipleRideFare(this.rideRespiratory.GetCabRides(userId));
        }
    }
}