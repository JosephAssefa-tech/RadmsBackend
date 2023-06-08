using RadmsEntities;
using RadmsRepositoryFacade;
using RadmsServiceFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceManager
{
    public class ImpactTypeService : IImpactTypeService
    {
        IImpactTypeRepository _repository;
        public ImpactTypeService(IImpactTypeRepository repository)
        {
            _repository = repository;
        }

        public string Delete(int impactTypeId)
        {
            if (impactTypeId != 0)
            {
                var result = _repository.Delete(impactTypeId);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c impactTypeId id is not given";
            }
        }

        public List<ImpactTypeLookupEntity> GetAll(string? language)
        {
            List<ImpactTypeLookupEntity> results = this._repository.GetAll(language);
            return results;
        }
        private string Validate(ImpactTypeLookupEntity entity)
        {
            if (entity.ImpactTypeName == String.Empty)
            {
                return "ImpactTypeName  name can not be empty";
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
        public string Save(ImpactTypeLookupEntity entity)
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
                    bool result = _repository.Save(entity);
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

        public string Update(ImpactTypeLookupEntity entity)
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
                    bool result = _repository.Update(entity);
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
