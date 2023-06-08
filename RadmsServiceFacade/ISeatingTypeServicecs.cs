using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface  ISeatingTypeServicecs
    {
        string Save(SeatingTypeLookupEntity entity);
        string Update(SeatingTypeLookupEntity entity);
        string Delete(int seatingTypeId);
        List<SeatingTypeLookupEntity> GetAll(string? language);
    }
}
