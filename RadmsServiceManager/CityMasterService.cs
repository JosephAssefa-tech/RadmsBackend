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
    public class CityMasterService : ICityMasterService
    {
        ICityMasterRepository _repositiory;
        public CityMasterService(ICityMasterRepository repositiory)
        {
            _repositiory = repositiory;

        }

        public string Delete(int cityId)
        {
            if (cityId != 0)
            {
                var result = _repositiory.Delete(cityId);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
        }

        private string Validate(CityMasterEntity entity)
        {
            if (entity.CityName == String.Empty)
            {
                return "City  name can not be empty";
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
        public string Save(CityMasterEntity city, string? selectedLanguage)
        {
            try
            {
                string msg = Validate(city);
                if (msg != String.Empty)
                {
                    return msg;
                }
                else
                {
                    bool result = _repositiory.Save(city, selectedLanguage);
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

        List<CityMasterEntity> ICityMasterService.GetAll(string language)
        {
            List<CityMasterEntity> results = this._repositiory.GetAll( language);
            return results;
        }
    }
}
