using RadmsDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class WeatherConditionTypeLookupEntity
    {
        public WeatherConditionTypeLookupEntity()
        {
     //     AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
        }


        public int WeatherCondId { get; set; }

        public string WeatherCondName { get; set; } = null!;

        public WeatherConditionTypeLookupEntity(WeatherConditionTypeLookup model)
        {
      this.WeatherCondId = model.WeatherCondId;
            this.WeatherCondName = model.WeatherCondName;

          
        }
        // public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }

    }
}
