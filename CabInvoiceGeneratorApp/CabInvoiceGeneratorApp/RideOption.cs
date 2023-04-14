using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGeneratorApp
{
    public class RideOption
    {
        public enum RideOptionType 
        { 
            NORMAL,PREMIUM,
        }
        public double CostPerKm;
        public double CostPerMin;
        public double Minimumfare;
        public RideOption(double costPerKm, double costPerMin, double minimumfare)
        {
            this.CostPerKm = costPerKm;
            this.CostPerMin = costPerMin;
            this.Minimumfare = minimumfare;
        }
        public RideOption()
        {

        }
        public RideOption SetRideValues(RideOptionType ridetypes)
        {
            switch(ridetypes)
            {
                case RideOptionType.NORMAL:
                    return new RideOption(10.0, 1.0, 5.0);
                case RideOptionType.PREMIUM:
                    return new RideOption(15.0, 2.0, 20);
                default:
                    return null;
            }
        }
    }
}
