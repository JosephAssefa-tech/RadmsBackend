using RadmsEntities;
using RadmsRepositoryFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceManager
{
    public class VechileServiceAgeService : IVechileServiceAgeService
    {
        IVechileServiceAgeRepository _repositiory;
        public VechileServiceAgeService(IVechileServiceAgeRepository repositiory)
        {
            _repositiory = repositiory;

        }

        public string Delete(int vehicleServiceAgeId)
        {
            if (vehicleServiceAgeId != 0)
            {
                var result = _repositiory.Delete(vehicleServiceAgeId);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
        }

        public List<VehicleServiceAgeLookupEntity> GetAll(string? language)
        {
            List<VehicleServiceAgeLookupEntity> results = this._repositiory.GetAll(language);
            return results;
        }
        private string Validate(VehicleServiceAgeLookupEntity entity)
        {
            if (entity.VehicleServiceName == String.Empty)
            {
                return "VehicleServiceName can not be empty";
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

        public string Save(VehicleServiceAgeLookupEntity entity)
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

        public string Update(VehicleServiceAgeLookupEntity entity)
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
