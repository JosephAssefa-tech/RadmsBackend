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
    public class SpeedLimitService : ISpeedLimitService
    {
        ISpeedLimitRepository _repository;
        public SpeedLimitService(ISpeedLimitRepository repository)
        {
            _repository = repository;
        }

        public string Delete(int speedLimitId)
        {
            if (speedLimitId != 0)
            {
                var result = _repository.Delete(speedLimitId);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
        }

        public List<SpeedLimitLookupEntity> GetAll(string? language)
        {
            List<SpeedLimitLookupEntity> results = this._repository.GetAll(language);
            return results;
        }
        private string Validate(SpeedLimitLookupEntity entity)
        {
            if (entity.SpeedLimitName == String.Empty)
            {
                return "SpeedLimitName can not be empty";
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
        public string Save(SpeedLimitLookupEntity entity)
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
                    bool result = _repository.Save(entity);
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

        public string Update(SpeedLimitLookupEntity entity)
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
