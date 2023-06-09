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
    public class HighwayMasterService : IHighwayMasterService
    {
        IHighwayMasterRepository _repository;
        public HighwayMasterService(IHighwayMasterRepository repository)
        {
                this._repository = repository;

        }

        public string Delete(string hid)
        {
            if (hid != null)
            {
                var result = _repository.Delete(hid);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c  hid is not given";
            }
        }

        public List<HighwayMasterEntity> GetAll(string? language)
        {
            List<HighwayMasterEntity> results = this._repository.GetAll(language);
            return results;
        }
        private string Validate(HighwayMasterEntity entity)
        {
            if (entity.Hname == String.Empty)
            {
                return "Hname  name can not be empty";
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
        public string Save(HighwayMasterEntity entity)
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

        public string Update(HighwayMasterEntity entity)
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
