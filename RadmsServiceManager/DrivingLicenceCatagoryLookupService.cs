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
    public class DrivingLicenceCatagoryLookupService : IDrivingLicenceCatagoryLookupService
    {
        IDrivingLicenceCatagoryLookupRepository _repositiory;
        public DrivingLicenceCatagoryLookupService(IDrivingLicenceCatagoryLookupRepository repositiory)
        {
            _repositiory = repositiory;

        }

        public string Delete(int drivingLicenceCatagoryId)
        {
            if (drivingLicenceCatagoryId != 0)
            {
                var result = _repositiory.Delete(drivingLicenceCatagoryId);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
           
        }

        public List<DrivingLicenceCatagoryLookupEntity> GetAll(string? language)
        {
            List<DrivingLicenceCatagoryLookupEntity> results = this._repositiory.GetAll(language);
            return results;
        }
        private string Validate(DrivingLicenceCatagoryLookupEntity entity)
        {
            if (entity.DrivingLicenceCatagoryName == String.Empty)
            {
                return "DrivingLicenceCatagoryName  name can not be empty";
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
        public string Save(DrivingLicenceCatagoryLookupEntity entity)
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

        public string Update(DrivingLicenceCatagoryLookupEntity entity)
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
