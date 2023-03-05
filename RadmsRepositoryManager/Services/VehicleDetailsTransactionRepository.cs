using RadmsDataAccessLogic;
using RadmsDataModels.Models;
using RadmsEntities;
using RadmsRepositoryFacade;
using RadmsRepositoryManager.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryManager.Services
{
    public class VehicleDetailsTransactionRepository : IVehicleDetailsTransactionRepository
    {
        RadmsContext context = new RadmsContext();
        //public VehicleDetailsTransactionRepository(RadmsContext context)
        //{
        //    this.context = context;
        //}

        public bool Delete(decimal id)
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

        public bool Save(VehicleDetailsTransactionEntity vechile)
        {
            try
            {
                CustomAccidentIdGenerator a = new CustomAccidentIdGenerator();
                var b = a.GetLastNumberFromDatabase();
                var c = b;

                VehicleDetailsTransaction model = vechile.MapToModel<VehicleDetailsTransaction>();
                model.AccidentId = c;
                context.VehicleDetailsTransactions.Add(model);

                context.SaveChanges();



                return true;
            }
            catch(Exception msg)
            {
                return false;
            }
          }

        public bool Update(VehicleDetailsTransactionEntity accident)
        {
            throw new NotImplementedException();
        }
    }
}
