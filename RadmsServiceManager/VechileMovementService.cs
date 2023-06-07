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
    public class VechileMovementService : IVechileMovementService
    {
        public IVechileMovementRespository _repositiory;
        public VechileMovementService(IVechileMovementRespository repository)
        {
            this._repositiory = repository;
        }

        public string Delete(int vehicleMovementId)
        {
            if (vehicleMovementId != 0)
            {
                var result = _repositiory.Delete(vehicleMovementId);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
        }

        public List<VehicleMovementMasterEntity> GetAll(string? language)
        {
            List<VehicleMovementMasterEntity> results = this._repositiory.GetAll(language);
            return results;
        }


        private string Validate(VehicleMovementMasterEntity entity)
        {
            if (entity.VehicleMovementMasterName == String.Empty)
            {
                return "VehicleMovementMasterName  can not be empty";
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

        public string Save(VehicleMovementMasterEntity entity)
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

        public string Update(VehicleMovementMasterEntity entity)
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
