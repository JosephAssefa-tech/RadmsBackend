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
    public class PoliceStationMasterService : IPoliceStationMaster
    {
        IPoliceStationMasterRepository _repository;
        public PoliceStationMasterService(IPoliceStationMasterRepository repository)
        {
            _repository = repository;

        }

        public string Delete(string id)
        {
            if (id != null)
            {
                var result = _repository.Delete(id);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
        }

        public PoliceStationMasterEntity FilterByAccidentName(string CauseName)
        {
            throw new NotImplementedException();
        }

        public List<PoliceStationMasterEntity> GetAll()
        {
            List<PoliceStationMasterEntity> results = this._repository.GetAll();
            return results;
        }

        public PoliceStationMasterEntity GetById(string id)
        {
            var result = _repository.GetById(id);
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new Exception();
            }
        }
        private string Validate(PoliceStationMasterEntity entity)
        {
            if (entity.Psid == null)
            {
                return entity.Psid;
            }
            //else if(entity.startDate>entity.endDate)
            //{
            //    return "start date can't be greater than end date";
            //}
            else
            {
                return entity.Psid;
            }

        }

        public bool Save(PoliceStationMasterEntity accident)
        {
            try
            {


                var result = _repository.Save(accident);
                // if (result != 0)
                //  {
                return result;
                //  }
                //  else
                //  {
                //       return 0 ;

                //   }
                //  }
            }
            catch (Exception)
            {
                throw;

            }

        }
            

    public string Update(PoliceStationMasterEntity accident)
        {
            try
            {
                //  string msg = Validate(accident);
                //  if (msg != String.Empty)
                //  {
                //      return msg;
                //  }
                //  else
                //  {
                bool result = _repository.Update(accident);
                if (result == true)
                {
                    return "Updated sucessfuly";
                }
                else
                {
                    return "unkown error occured";

                }
                //  }

            }
            catch (Exception)
            {
                throw;

            }
        }
    }
}
