using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface ICourtCaseTransactionService
    {
        string Save(CourtCaseTransactionEntities entity);
        string Update(CourtCaseTransactionEntities entity);
        string Delete(int ID);
        List<CourtCaseTransactionEntities> GetAll(string? language);

    }
}
