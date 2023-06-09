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
    public class DriverExperienceLookupService : IDriverExperienceLookupService
    {
        IDriverExperienceLookupRepository _repositiory;
        public DriverExperienceLookupService(IDriverExperienceLookupRepository repositiory)
        {
            _repositiory = repositiory;

        }

        public string Delete(int driverExperienceId)
        {
            if (driverExperienceId != 0)
            {
                var result = _repositiory.Delete(driverExperienceId);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
        }

        public List<DriverExperienceLookupEntity> GetAll(string? language)
        {
            List<DriverExperienceLookupEntity> results = this._repositiory.GetAll(language);
            return results;
        }
        private string Validate(DriverExperienceLookupEntity entity)
        {
            if (entity.DriverExperienceName == String.Empty)
            {
                return "DriverExperienceName  name can not be empty";
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

        public string Save(DriverExperienceLookupEntity entity)
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

        public string Update(DriverExperienceLookupEntity entity)
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
