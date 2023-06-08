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
    public class TerrainTypeService : ITerrainTypeService
    {
        ITerrianTypeRepository _repository;
        public TerrainTypeService(ITerrianTypeRepository repository)
        {
            _repository = repository;
        }

        public string Delete(int terrianTypeId)
        {
            if (terrianTypeId != 0)
            {
                var result = _repository.Delete(terrianTypeId);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
        }

        public List<TerrainTypeLookupEntity> GetAll(string? language)
        {
            List<TerrainTypeLookupEntity> results = this._repository.GetAll(language);
            return results;
        }
        private string Validate(TerrainTypeLookupEntity entity)
        {
            if (entity.TerrianName == String.Empty)
            {
                return "TerrianName  name can not be empty";
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

        public string Save(TerrainTypeLookupEntity entity)
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

        public string Update(TerrainTypeLookupEntity entity)
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
