using RadmsEntities;
using RadmsServiceFacade.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public class IpaymentType : IGenericService<PavementTypeLookupEntity>
    {
        public bool Delete(decimal id)
        {
            throw new NotImplementedException();
        }

        public PavementTypeLookupEntity FilterByAccidentName(string CauseName)
        {
            throw new NotImplementedException();
        }

        public List<PavementTypeLookupEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public PavementTypeLookupEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(PavementTypeLookupEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(PavementTypeLookupEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
