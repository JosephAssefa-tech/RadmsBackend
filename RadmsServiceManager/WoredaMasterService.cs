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
    public class WoredaMasterService : IWoredaMasterService
    {

        IWoredaMasterRepository _repositiory;
        public WoredaMasterService(IWoredaMasterRepository repositiory)
        {
            _repositiory = repositiory;

        }
        public List<WoredaMasterEntity> GetAll(string language)
        {
            List<WoredaMasterEntity> results = this._repositiory.GetAll(language);
            return results;
        }
        private string Validate(WoredaMasterEntity entity)
        {
            if (entity.WoredaName == String.Empty)
            {
                return "Woreda  name can not be empty";
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

        public string Save(WoredaMasterEntity entity)
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
                    string result = _repositiory.Save(entity);
                    if (result!="")
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
    }
}
