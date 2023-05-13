using RadmsDataAccessLogic;
using RadmsDataModels.Models;
using RadmsEntities;
using RadmsRepositoryFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryManager.Services
{
    public class RoadsInvolvedDetailsTransactionRepository : IRoadsInvolvedDetailsTransactionRepository
    {
        RadmsContext context = new RadmsContext();
        public bool Delete(decimal id)
        {
            throw new NotImplementedException();
        }

        public RoadsInvolvedDetailsTransactionEntity FilterByAccidentName(string CauseName)
        {
            throw new NotImplementedException();
        }

        public List<RoadsInvolvedDetailsTransactionEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public RoadsInvolvedDetailsTransactionEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(RoadsInvolvedDetailsTransactionEntity road)
        {
            try
            {
                //   CustomAccidentIdGenerator a = new CustomAccidentIdGenerator();
                //  var b = a.GetLastNumberFromDatabase();
                //  var c = b;

                RoadsInvolvedDetailsTransaction model = road.MapToModel<RoadsInvolvedDetailsTransaction>();
                
                context.RoadsInvolvedDetailsTransactions.Add(model);

                context.SaveChanges();



                return true;
            }
            catch (Exception msg)
            {
                return false;
            }
        }

        public bool Update(RoadsInvolvedDetailsTransactionEntity road)
        {
            throw new NotImplementedException();
        }
    }
}
