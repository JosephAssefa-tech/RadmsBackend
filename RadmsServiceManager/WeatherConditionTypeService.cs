using RadmsEntities;
using RadmsRepositoryFacade;
using RadmsServiceFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceManager
{
    public class WeatherConditionTypeService : IWeatherConditionType
    {
        IWeatherConditionTypeRepository _repository;
        public WeatherConditionTypeService(IWeatherConditionTypeRepository repository)
        {
            _repository = repository;
        }

        public string Delete(int weatherConditionId)
        {
            if (weatherConditionId != 0)
            {
                var result = _repository.Delete(weatherConditionId);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
        }

        public List<WeatherConditionTypeLookupEntity> GetAll(string language)
        {
            List<WeatherConditionTypeLookupEntity> results = this._repository.GetAll(language);
            return results;
        }
        private string Validate(WeatherConditionTypeLookupEntity entity)
        {
            if (entity.WeatherCondName == String.Empty)
            {
                return "Weather condition name can not be empty";
            }
            //else if(entity.startDate>entity.endDate)
            //{
            //    return "start date can't be greater than end date";
            //}
            else
            {
                return string.Empty;
            }

        }

        public string Save(WeatherConditionTypeLookupEntity weather)
        {
            try
            {
                string msg = Validate(weather);
                if (msg != String.Empty)
                {
                    return msg;
                }
                else
                {
                    bool result = _repository.Save(weather);
                    if (result == true)
                    {
                        return "saved sucessfuly";
                    }
                    else
                    {
                        return "unkown error occured";

                    }
                }

            }
            catch (Exception)
            {
                throw;

            }
        }

        public string Update(WeatherConditionTypeLookupEntity entity)
        {
            try
            {
                string msg = Validate(entity);
                if (msg != String.Empty)
                {
                    return msg;
                }
                else
                {
                    bool result = _repository.Update(entity);
                    if (result == true)
                    {
                        return "Updated sucessfuly";
                    }
                    else
                    {
                        return "unkown error occured";

                    }
                }

            }
            catch (Exception)
            {
                throw;

            }
        }
    }
}
