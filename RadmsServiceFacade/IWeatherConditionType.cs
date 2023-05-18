using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface IWeatherConditionType
    {
        string Save(WeatherConditionTypeLookupEntity accident);
        string Update(WeatherConditionTypeLookupEntity accident);
        string Delete(decimal id);
        List<WeatherConditionTypeLookupEntity> GetAll(string language);
    }
}
