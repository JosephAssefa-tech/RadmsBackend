using RadmsDataAccessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryManager.Helpers
{

    public class GetLastVictmId
    {
        private readonly RadmsContext _dbContext;
        public GetLastVictmId()
        {
           

        }
        public GetLastVictmId(RadmsContext context)
        { 
            this._dbContext = context;
           
        }

        public string GetLastVictmIdofAccident()
        {
            // Query the database to retrieve the last inserted data's ID
            using (var db = new RadmsContext())
            {
                var lastData = db.VictimDetailsTransactions.OrderByDescending(d => d.VictimId).FirstOrDefault();
                if (lastData != null)
                {
                    // Parse the last number from the ID and return it
                    return lastData.VictimId;
                }
                else
                {
                    // If no data is found, return 0 as the starting number
                    return "not found";
                }
            }
        }

    }
}
