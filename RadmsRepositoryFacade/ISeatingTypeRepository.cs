using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface  ISeatingTypeRepository
    {
        bool Save(SeatingTypeLookupEntity entity);
        bool Update(SeatingTypeLookupEntity entity);
        bool Delete(int seatingTypeId);
        List<SeatingTypeLookupEntity> GetAll(string? language);
    }
}
