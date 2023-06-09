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
    public class HighWayTypeSerivice : IHighWayTypeSerivice
    {
        IHighWayTypeRepository _repository;
        public HighWayTypeSerivice(IHighWayTypeRepository repository)
        {
            _repository = repository;
        }

        public string Delete(int htypeId)
        {
            throw new NotImplementedException();
        }

        public List<HighwayTypeLookupEntity> GetAll(string? languge)
        {
            List<HighwayTypeLookupEntity> results = this._repository.GetAll(languge);
            return results;
        }
        private string Validate(HighwayTypeLookupEntity entity)
        {
            if (entity.HtypeName == String.Empty)
            {
                return "HtypeName  name can not be empty";
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

        public string Save(HighwayTypeLookupEntity entity)
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

        public string Update(HighwayTypeLookupEntity entity)
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

