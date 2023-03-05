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
    public class LegalMeasurementDetailsTransactionRepository : ILegalMeasurementDetailsTransactionRepository
    {
        RadmsContext context = new RadmsContext();
        public bool Delete(decimal id)
        {
            throw new NotImplementedException();
        }

        public LegalMeasurementDetailsTransactionEntity FilterByAccidentName(string CauseName)
        {
            throw new NotImplementedException();
        }

        public List<LegalMeasurementDetailsTransactionEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public LegalMeasurementDetailsTransactionEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(LegalMeasurementDetailsTransactionEntity legal)
        {
            try
            {
                CustomAccidentIdGenerator a = new CustomAccidentIdGenerator();
                var b = a.GetLastNumberFromDatabase();
                var c = b;

                //GetLastVictmId victmId = new GetLastVictmId();
                //var res = victmId.GetLastVictmIdofAccident();
                //var result = res;



                LegalMeasurementDetailsTransaction model = legal.MapToModel<LegalMeasurementDetailsTransaction>();
                model.AccidentId = c;
         //       model.VictimId = result;
                context.LegalMeasurementDetailsTransactions.Add(model);

                context.SaveChanges();

                return true;
            }
            catch (Exception msg)
            {
                return false;
            }
        }

        public bool Update(LegalMeasurementDetailsTransactionEntity accident)
        {
            throw new NotImplementedException();
        }
    }
}
