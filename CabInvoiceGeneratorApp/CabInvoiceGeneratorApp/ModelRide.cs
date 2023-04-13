using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGeneratorApp
{
    public class ModelRide
    {
        public double RideDistance;
        public double RideTime;

        public ModelRide(double RideDistance, double RideTime)
        {
            this.RideDistance = RideDistance;
            this.RideTime = RideTime;
        }
    }
}
