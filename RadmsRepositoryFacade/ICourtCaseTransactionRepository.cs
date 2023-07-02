using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface  ICourtCaseTransactionRepository
    {
        bool Save(CourtCaseTransactionEntities entity);
        bool Update(CourtCaseTransactionEntities entity);
        bool Delete(int ID);
        List<CourtCaseTransactionEntities> GetAll(string? language);

    }
}
