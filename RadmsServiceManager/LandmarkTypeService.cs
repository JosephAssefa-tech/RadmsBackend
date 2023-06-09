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
    public class LandmarkTypeService : ILandmarkTypeService
    {
        public ILandmarkTypeRepository _repository;
        public LandmarkTypeService(ILandmarkTypeRepository repository)
        {
            _repository = repository;
        }

        public string Delete(int landmarkTypeId)
        {
            throw new NotImplementedException();
        }

        public List<LandmarkTypeLookupEntity> GetAll(string? langugae)
        {
            List<LandmarkTypeLookupEntity> results = this._repository.GetAll(langugae);
            return results;
        }
        private string Validate(LandmarkTypeLookupEntity entity)
        {
            if (entity.LandmarkName == String.Empty)
            {
                return "LandmarkName  name can not be empty";
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

        public string Save(LandmarkTypeLookupEntity entity)
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

        public string Update(LandmarkTypeLookupEntity entity)
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
