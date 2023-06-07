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
    public class VehicleDefectServicecs: IVehicleDefectService
    {
        IVehicleDefectRepository _repositiory;
        public VehicleDefectServicecs(IVehicleDefectRepository repositiory)
        {
            _repositiory = repositiory;

        }

        public List<VehicleDefectLookupEntity> GetAll(string? language)
        {
            List<VehicleDefectLookupEntity> results = this._repositiory.GetAll(language);
            return results;
        }
        private string Validate(VehicleDefectLookupEntity entity)
        {
            if (entity.VehicleDefectName == String.Empty)
            {
                return "VehicleDefectName   can not be empty";
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

        public string Save(VehicleDefectLookupEntity entity)
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
        public string Update(VehicleDefectLookupEntity entity)
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
        public string Delete(int VehicleDefectId)
        {
            if (VehicleDefectId != 0)
            {
                var result = _repositiory.Delete(VehicleDefectId);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
        }
    }
}
