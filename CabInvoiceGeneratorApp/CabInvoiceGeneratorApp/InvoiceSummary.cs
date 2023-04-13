using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGeneratorApp
{
    public class InvoiceSummary
    {
        public double TotalFare;
        public double AvgFare;
        public int No_Of_Rides;
        public InvoiceSummary(double TotalFare,int No_Of_Rides)
        {
            this.TotalFare = TotalFare;
            this.No_Of_Rides = No_Of_Rides;
            this.AvgFare= this.TotalFare/ this.No_Of_Rides;
        }
    }
}
