using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface  IRoadsInvolvedDetailsTransactionService
    {
        RoadsInvolvedDetailsTransactionEntity GetById(int id);
        RoadsInvolvedDetailsTransactionEntity FilterByAccidentName(string CauseName);
        string Save(RoadsInvolvedDetailsTransactionEntity accident);
        string Update(RoadsInvolvedDetailsTransactionEntity accident);
        string Delete(decimal id);
        List<RoadsInvolvedDetailsTransactionEntity> GetAll();
    }
}
