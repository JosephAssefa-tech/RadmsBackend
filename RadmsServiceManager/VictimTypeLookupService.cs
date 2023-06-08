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
    public class VictimTypeLookupService : IVictimTypeLookupService
    {
        IVictimTypeLookupRepository _repositiory;
        public VictimTypeLookupService(IVictimTypeLookupRepository repositiory)
        {
            _repositiory = repositiory;

        }

        public string Delete(int victimTypeId)
        {
            if (victimTypeId != 0)
            {
                var result = _repositiory.Delete(victimTypeId);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
        }

        public List<VictimTypeLookupEntity> GetAll(string? language)
        {
            List<VictimTypeLookupEntity> results = this._repositiory.GetAll(language);
            return results;
        }
        private string Validate(VictimTypeLookupEntity entity)
        {
            if (entity.VictimType == String.Empty)
            {
                return "VictimType  name can not be empty";
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

        public string Save(VictimTypeLookupEntity entity)
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

        public string Update(VictimTypeLookupEntity entity)
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
