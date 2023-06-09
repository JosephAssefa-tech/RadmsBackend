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
    public class RoadCarriagewayTypeService : IRoadCarriagewayTypeService
    {
        IRoadCarriagewayTypeRepository _repository;
        public RoadCarriagewayTypeService(IRoadCarriagewayTypeRepository repository)
        {
            _repository = repository;
        }

        public string Delete(int roadCarriagewayId)
        {
            if (roadCarriagewayId != 0)
            {
                var result = _repository.Delete(roadCarriagewayId);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
        }

        public List<RoadCarriagewayTypeLookupEntity> GetAll(string? language)
        {
            List<RoadCarriagewayTypeLookupEntity> results = this._repository.GetAll(language);
            return results;
        }
        private string Validate(RoadCarriagewayTypeLookupEntity entity)
        {
            if (entity.RoadCarriagewayName == String.Empty)
            {
                return "RoadCarriagewayName  name can not be empty";
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

        public string Save(RoadCarriagewayTypeLookupEntity entity)
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

        public string Update(RoadCarriagewayTypeLookupEntity entity)
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
