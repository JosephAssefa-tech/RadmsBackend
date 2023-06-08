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

        public string Delete(int pavementTypeId)
        {
            if (pavementTypeId != 0)
            {
                var result = _repositiory.Delete(pavementTypeId);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
        }

        public List<PavementTypeLookupEntity> GetAll(string? language)
        {
            List<PavementTypeLookupEntity> results = this._repositiory.GetAll(language);
            return results;
        }
        private string Validate(PavementTypeLookupEntity entity)
        {
            if (entity.PavementName == String.Empty)
            {
                return "PavementName  name can not be empty";
            }
            //else if(entity.startDate>entity.endDate)
            //{
            //    return "start date can't be greater than end date";
            //}
            else
            {
                return string.Empty;
            }

        }

        public string Save(PavementTypeLookupEntity entity)
        {
            try
            {
                string msg = Validate(entity);
                if (msg != String.Empty)
                {
                    return msg;
                }
                else
                {
                    bool result = _repositiory.Save(entity);
                    if (result == true)
                    {
                        return "saved sucessfuly";
                    }
                    else
                    {
                        return "unkown error occured";

                    }
                }

            }
            catch (Exception)
            {
                throw;

            }
        }

        public string Update(PavementTypeLookupEntity entity)
        {
            try
            {
                string msg = Validate(entity);
                if (msg != String.Empty)
                {
                    return msg;
                }
                else
                {
                    bool result = _repositiory.Update(entity);
                    if (result == true)
                    {
                        return "Updated sucessfuly";
                    }
                    else
                    {
                        return "unkown error occured";

                    }
                }

            }
            catch (Exception)
            {
                throw;

            }
        }
    }
}
