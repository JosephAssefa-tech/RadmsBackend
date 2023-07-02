using RadmsDataAccessLogic;
using RadmsDataModels.Modelss;
using RadmsEntities;
using RadmsRepositoryFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryManager.Services
{
    public class CourtCaseTransactionRepository : ICourtCaseTransactionRepository
    {
        RadmsContext context = new RadmsContext();
        public bool Delete(int ID)
        {
            try
            {
                var result = context.CourtCaseTransactions.Where(x => x.Id == ID).FirstOrDefault();
                if (result != null)
                {
                    context.CourtCaseTransactions.Remove(result);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;

                }

            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<CourtCaseTransactionEntities> GetAll(string? language)
        {
            throw new NotImplementedException();
        }

        public bool Save(CourtCaseTransactionEntities entity)
        {
            try
            {
                CourtCaseTransaction model = entity.MapToModel<CourtCaseTransaction>();


                context.CourtCaseTransactions.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;


            }
        }

        public bool Update(CourtCaseTransactionEntities entity)
        {
            throw new NotImplementedException();
        }
    }
}
