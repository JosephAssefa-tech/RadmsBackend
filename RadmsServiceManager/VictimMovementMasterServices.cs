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
    public class VictimMovementMasterServices : IVictimMovementMasterService
    {
        IVictimMovementMasterRepository _repositiory;
        public VictimMovementMasterServices(IVictimMovementMasterRepository repositiory)
        {
            _repositiory = repositiory;

        }
        public List<VictimMovementMasterEntity> GetAll(string? language)
        {
            List<VictimMovementMasterEntity> results = this._repositiory.GetAll(language);
            return results;
        }
        private string Validate(VictimMovementMasterEntity entity)
        {
            if (entity.VictimMovementType == String.Empty)
            {
                return "VictimMovementType   can not be empty";
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

        public string Save(VictimMovementMasterEntity entity)
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
        public string Update(VictimMovementMasterEntity entity)
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
        public string Delete(int victimMovementId)
        {
            if (victimMovementId != 0)
            {
                var result = _repositiory.Delete(victimMovementId);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
        }
    }
}
