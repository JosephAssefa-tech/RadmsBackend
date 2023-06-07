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
    public class AirConditionTypeService : IAirConditionTypeService
    {
        IAirConditionTypeRepository _repositiory;
        public AirConditionTypeService(IAirConditionTypeRepository repositiory)
        {
            _repositiory = repositiory;

        }

        public string Delete(int airConditionTypeId)
        {
            if (airConditionTypeId != 0)
            {
                var result = _repositiory.Delete(airConditionTypeId);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
        }
        private string Validate(AirConditionTypeLookupEntity entity)
        {
            if (entity.AirConditionName == String.Empty)
            {
                return "Aircondition  name can not be empty";
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

        public List<AirConditionTypeLookupEntity> GetAll(string language)
        {
            List<AirConditionTypeLookupEntity> results = this._repositiory.GetAll(language);
            return results;
        }

        public string Save(AirConditionTypeLookupEntity entity)
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
                    bool result = _repositiory.Save(entity);
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

        public string Update(AirConditionTypeLookupEntity entity)
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
                    bool result = _repositiory.Update(entity);
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
