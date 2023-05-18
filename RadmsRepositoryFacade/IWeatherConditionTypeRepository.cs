using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface IWeatherConditionTypeRepository
    {
        bool Save(WeatherConditionTypeLookupEntity accident);
        bool Update(WeatherConditionTypeLookupEntity accident);
        bool Delete(decimal id);
        List<WeatherConditionTypeLookupEntity> GetAll(string language);
        WeatherConditionTypeLookupEntity GetById(int id);
        WeatherConditionTypeLookupEntity FilterByAccidentName(string CauseName);
    }
}
