using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface  IRoadsInvolvedDetailsTransactionRepository
    {
        RoadsInvolvedDetailsTransactionEntity GetById(int id);
        RoadsInvolvedDetailsTransactionEntity FilterByAccidentName(string CauseName);
        bool Save(RoadsInvolvedDetailsTransactionEntity road);
        bool Update(RoadsInvolvedDetailsTransactionEntity road);
        bool Delete(decimal id);
        List<RoadsInvolvedDetailsTransactionEntity> GetAll();
    }
}
