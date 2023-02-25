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
    public class VehicleDetailsTransactionService : IVehicleDetailsTransaction
    {
         IVehicleDetailsTransactionRepository _repository;
        public VehicleDetailsTransactionService(IVehicleDetailsTransactionRepository repository)
        {
            _repository = repository;
        }
        public string Delete(decimal id)
        {
            throw new NotImplementedException();
        }

        public VehicleDetailsTransactionEntity FilterByAccidentName(string CauseName)
        {
            throw new NotImplementedException();
        }

        public List<VehicleDetailsTransactionEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public VehicleDetailsTransactionEntity GetById(int id)
        {
            throw new NotImplementedException();
        }
        private string Validate(VehicleDetailsTransactionEntity entity)
        {
            if (entity.DriverName == String.Empty)
            {
                return "Driver name can not be empty";
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

        public string Save(VehicleDetailsTransactionEntity vechile)
        {
            try
            {
                string msg = Validate(vechile);
                if (msg != String.Empty)
                {
                    return msg;
                }
                else
                {
   

                    bool result = _repository.Save(vechile);
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

        public string Update(VehicleDetailsTransactionEntity accident)
        {
            throw new NotImplementedException();
        }
    }
}
