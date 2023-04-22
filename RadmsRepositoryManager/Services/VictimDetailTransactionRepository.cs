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
    public class VictimDetailTransactionRepository : IVictimDetailTransactionRepository
    {
        RadmsContext context = new RadmsContext();
        public bool Delete(decimal id)
        {
            throw new NotImplementedException();
        }

        public VictimDetailsTransactionEntity FilterByAccidentName(string CauseName)
        {
            throw new NotImplementedException();
        }

        public List<VictimDetailsTransactionEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public VictimDetailsTransactionEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        //public IQueryable<SummaryCount> GetFatalCount()
        //{
        //    var result = context.VictimDetailsTransactions.ToList();
        //    var counts = result.GroupBy(x => x.EmploymentStatus)
        //        .Select(s => new SummaryCount
        //        {
        //            Severity = s.Key,
        //            Count = s.Count()

        //        }).ToList();

        //    return (IQueryable<SummaryCount>)counts;
        //}

        public int GetSeriousCount()
        {
            throw new NotImplementedException();
        }

        public int GetSlightCount()
        {
            throw new NotImplementedException();
        }

        public bool Save(VictimDetailsTransactionEntity victm)
        {
            try
            {
                //CustomAccidentIdGenerator a = new CustomAccidentIdGenerator();
                //var b = a.GetLastNumberFromDatabase();
                //var c = b;

                VictimDetailsTransaction model = victm.MapToModel<VictimDetailsTransaction>();
              //  model.AccidentId = c;
                context.VictimDetailsTransactions.Add(model);

                context.SaveChanges();

                var result = model.VictimId;
                if (victm.AccidentId != model.AccidentId)
                {

                }
                else if(victm.AccidentId==model.AccidentId)
                {

                }



                return true;
            }
            catch (Exception msg)
            {
                return false;
            }
        }

        public bool Update(VictimDetailsTransactionEntity accident)
        {
            throw new NotImplementedException();
        }
    }
}
