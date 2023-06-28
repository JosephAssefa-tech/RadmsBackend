using RadmsEntities;
using RadmsRepositoryFacade;
using RadmsServiceFacade;

namespace RadmsServiceManager
{
    public class CourtChargeTypeService : ICourtChargeTypeService
    {
        ICourtChargeTypeLookupRepository _repositiory;
        public CourtChargeTypeService(ICourtChargeTypeLookupRepository repositiory)
        {
            _repositiory = repositiory;
        }

        public string Delete(int courtChargeID)
        {
            if (courtChargeID != 0)
            {
                var result = _repositiory.Delete(courtChargeID);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
        }

        public List<CourtChargeTypeLookupEntity> GetAll(string? language)
        {
            List<CourtChargeTypeLookupEntity> results = this._repositiory.GetAll(language);
            return results;
        }
        private string Validate(CourtChargeTypeLookupEntity entity)
        {
            if (entity.CourtChargeType == String.Empty)
            {
                return "CourtChargeType  name can not be empty";
            }

            else
            {
                return string.Empty;
            }

        }

        public string Save(CourtChargeTypeLookupEntity entity)
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

        public string Update(CourtChargeTypeLookupEntity entity)
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
