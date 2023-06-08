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
    public class LicenceLevelLookupService : ILicenceLevelLookupService
    {
        ILicenceLevelLookupRepository _repositiory;
        public LicenceLevelLookupService(ILicenceLevelLookupRepository repositiory)
        {
            _repositiory = repositiory;

        }

        public string Delete(int leveloflicenceId)
        {
            if (leveloflicenceId != 0)
            {
                var result = _repositiory.Delete(leveloflicenceId);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
        }

        public List<LicenceLevelLookupEntity> GetAll(string? language)
        {
            List<LicenceLevelLookupEntity> results = this._repositiory.GetAll(language);
            return results;
        }
        private string Validate(LicenceLevelLookupEntity entity)
        {
            if (entity.LeveloflicenceName == String.Empty)
            {
                return "LeveloflicenceName  name can not be empty";
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

        public string Save(LicenceLevelLookupEntity entity)
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

        public string Update(LicenceLevelLookupEntity entity)
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
