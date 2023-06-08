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
    public class AccidentTypeService : IAccidentType
    {
        IAccidentTypeRepository _repositiory;
        public AccidentTypeService(IAccidentTypeRepository repositiory)
        {
            _repositiory = repositiory;

        }

        public string Delete(int accidentTypeId)
        {
            if (accidentTypeId != 0)
            {
                var result = _repositiory.Delete(accidentTypeId);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
        }

        public List<AccidentTypeLookupEntity> GetAll(string language)
        {
            List<AccidentTypeLookupEntity> results = this._repositiory.GetAll(language);
            return results;
        }
        private string Validate(AccidentTypeLookupEntity entity)
        {
            if (entity.AccidentType == String.Empty)
            {
                return "AccidentType  name can not be empty";
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

        public string Save(AccidentTypeLookupEntity entity)
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

        public string Update(AccidentTypeLookupEntity entity)
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
