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

    public class RegionMasterService : IRegionMaster
    {
        IRegionMasterRepository _repositiory;
        public RegionMasterService(IRegionMasterRepository repositiory)
        {
            _repositiory = repositiory;

        }

        public string Delete(decimal id)
        {
            if (id != 0)
            {
                var result = _repositiory.Delete(id);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
        }

        public RegionMasterEntity FilterByAccidentName(string CauseName)
        {
            throw new NotImplementedException();
        }

        public List<RegionMasterEntity> GetAll(string language)
        {
            List<RegionMasterEntity> results = this._repositiory.GetAll(language);
            return results;
        }

        public RegionMasterEntity GetById(int id)
        {
            var result = _repositiory.GetById(id);
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new Exception();
            }
        }
        private string Validate(RegionMasterEntity entity)
        {
            if (entity.RegionName == String.Empty)
            {
                return "Region  name can not be empty";
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

        public string Save(RegionMasterEntity entity)
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
                    if (result==true)
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

        public bool Update(RegionMasterEntity accident)
        {
            throw new NotImplementedException();
        }

        string IRegionMaster.Update(RegionMasterEntity accident)
        {
            throw new NotImplementedException();
        }
    }
}
