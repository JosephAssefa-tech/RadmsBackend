using Microsoft.EntityFrameworkCore;
using RadmsDataAccessLogic;
using RadmsDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryManager.Helpers
{
    public class CustomAccidentIdGenerator
    {
        private readonly RadmsContext _dbContext;
        public CustomAccidentIdGenerator()
        {

        }
        public CustomAccidentIdGenerator(RadmsContext context)
        {
            this._dbContext = context;
        }
        public decimal GetLastNumberFromDatabase()
        {
            // Query the database to retrieve the last inserted data's ID
            using (var db = new RadmsContext())
            {
                var lastData = db.AccidentDetailsTransactions.OrderByDescending(d => d.AccidentId).FirstOrDefault();
                if (lastData != null)
                {
                    // Parse the last number from the ID and return it
                    return lastData.AccidentId;
                }
                else
                {
                    // If no data is found, return 0 as the starting number
                    return 0;
                }
            }
        }
    }
}
