using RadmsEntities;
using RadmsRepositoryFacade;
using RadmsServiceFacade;

namespace RadmsServiceManager
{
    public class VehicleOwnershipService : IVehicleOwnershipService
    {
        IVehicleOwnershipRepository _repositiory;
        public VehicleOwnershipService(IVehicleOwnershipRepository repositiory)
        {
            _repositiory = repositiory;

        }

        public string Delete(int vehicleOwnershipId)
        {
            if (vehicleOwnershipId != 0)
            {
                var result = _repositiory.Delete(vehicleOwnershipId);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
        }

        public List<VehicleOwnershipLookupEntity> GetAll(string? language)
        {
            List<VehicleOwnershipLookupEntity> results = this._repositiory.GetAll(language);
            return results;
        }
        private string Validate(VehicleOwnershipLookupEntity entity)
        {
            if (entity.VehicleOwnershipName == String.Empty)
            {
                return "VehicleOwnershipName can not be empty";
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

        public string Save(VehicleOwnershipLookupEntity entity)
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

        public string Update(VehicleOwnershipLookupEntity entity)
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
