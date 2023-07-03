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
    public class ZoneMasterService: IZoneMasterService
    {
        IZoneMasterRepository _repositiory;

        public ZoneMasterService(IZoneMasterRepository repositiory)
        {
            _repositiory = repositiory;

        }
        private string Validate(ZoneMasterEntity entity)
        {
            if (entity.ZoneName == String.Empty)
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

        public string Save(ZoneMasterEntity zoneEntity, string? selectedLanguage)
        {
            try
            {
                string msg = Validate(zoneEntity);
                if (msg != String.Empty)
                {
                    return msg;
                }
                else
                {
                    bool result = _repositiory.Save(zoneEntity, selectedLanguage);
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
        public string Update(ZoneMasterEntity entity)
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

        List<ZoneMasterEntity> IZoneMasterService.GetAll(string language,int? regionId)
        {
            List<ZoneMasterEntity> results = this._repositiory.GetAll(language, regionId);
            return results;
        }
        public string Delete(int zoneId)
        {
            if (zoneId != 0)
            {
                var result = _repositiory.Delete(zoneId);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
        }
    }
}
