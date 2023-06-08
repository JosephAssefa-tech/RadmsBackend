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
    public class CollisionTypeService : ICollisionTypeLookupService
    {
        ICollisionTypeRepository _repositiory;
        public CollisionTypeService(ICollisionTypeRepository repositiory)
        {
            _repositiory = repositiory;

        }

        public string Delete(int collisionTypeId)
        {
            if (collisionTypeId != 0)
            {
                var result = _repositiory.Delete(collisionTypeId);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
        }
        private string Validate(CollisionTypeLookupEntity entity)
        {
            if (entity.CollisionTypeName == String.Empty)
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
        public List<CollisionTypeLookupEntity> GetAll(string? language)
        {
            List<CollisionTypeLookupEntity> results = this._repositiory.GetAll(language);
            return results;
        }

        public string Save(CollisionTypeLookupEntity entity)
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

        public string Update(CollisionTypeLookupEntity entity)
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
