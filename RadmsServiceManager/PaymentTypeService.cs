using RadmsEntities;
using RadmsRepositoryFacade;
using RadmsServiceFacade;
using RadmsServiceFacade.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceManager
{
    public class PaymentTypeService : IpaymentType
    {
        IPaymentTypeRepository _repositiory;
        public PaymentTypeService(IPaymentTypeRepository repositiory)
        {
            _repositiory = repositiory;

        }
        public List<PavementTypeLookupEntity> GetAll(string language)
        {
            List<PavementTypeLookupEntity> results = this._repositiory.GetAll(language);
            return results;
        }
    }
}
