
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
    public class PedestrianMovementLookupServices : IPedestrianMovementLookupService
    {
        IPedestrianMovementLookupRepository _repositiory;
        public PedestrianMovementLookupServices(IPedestrianMovementLookupRepository repositiory)
        {
            _repositiory = repositiory;

        }

        public string Delete(int pedestrianMovementId)
        {
            if (pedestrianMovementId != 0)
            {
                var result = _repositiory.Delete(pedestrianMovementId);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
        }

        public List<PedestrianMovementLookupEntity> GetAll(string? language)
        {
            List<PedestrianMovementLookupEntity> results = this._repositiory.GetAll(language);
            return results;
        }
        private string Validate(PedestrianMovementLookupEntity entity)
        {
            if (entity.PedestrianMovementName == String.Empty)
            {
                return "PedestrianMovementName  name can not be empty";
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
        public string Save(PedestrianMovementLookupEntity entity)
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

        public string Update(PedestrianMovementLookupEntity entity)
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
