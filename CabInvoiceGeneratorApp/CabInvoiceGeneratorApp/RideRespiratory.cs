using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGeneratorApp
{
    public class RideRespiratory
    {
        private Dictionary<string,List<ModelRide>> userRideList=new Dictionary<string,List<ModelRide>>();
        public void AddCabRides(string userId, ModelRide[] ride)
        {
            bool checklist=this.userRideList.ContainsKey(userId);
            if (checklist==false)
            {
                this.userRideList.Add(userId, new List<ModelRide>(ride));
            }
        }
        public ModelRide[] GetCabRides(string userId)
        {
            return this.userRideList[userId].ToArray();
        }
    }
}
