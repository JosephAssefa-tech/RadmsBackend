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
    public class AccidentService : IAccidentServiceCRUD, IAccidentService
    {
        IAccidentRepository _repositiory;
        public AccidentService(IAccidentRepository repository)
        {
            this._repositiory = repository;
        }
        public string Delete(decimal id)
        {
            if(id!=0)
            {
                var result = _repositiory.Delete(id);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
   
        }

        public List<AccidentCauseLookupEntity> GetAll()
        {
            List<AccidentCauseLookupEntity> results = this._repositiory.GetAll();
            return results;
        }
        private string Validate(AccidentCauseLookupEntity entity)
        {
            if (entity.AccidentCauseName == String.Empty)
            {
                return "Accident cause name can not be empty";
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

        public string Save(AccidentCauseLookupEntity entity)
        {
            try
            {
                string msg=Validate(entity);
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
            catch(Exception)
            {
                throw;

            }
        }

        public string Update(AccidentCauseLookupEntity entity)
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

        public AccidentCauseLookupEntity GetById(int id)
        {
            var result= _repositiory.GetById(id);
            if(result!=null)
            {
                return result;
            }
            else
            {
                throw new Exception();
            }
         
        }

        public AccidentCauseLookupEntity FilterByAccidentName(string CauseName)
        {
            throw new NotImplementedException();
        }
    }
}
