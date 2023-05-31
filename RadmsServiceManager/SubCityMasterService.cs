using RadmsEntities;
using RadmsRepositoryFacade;
using RadmsServiceFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public class SubCityMasterService : ISubCityMasterService
    {
        ISubCityRepository _repository;
        public SubCityMasterService(ISubCityRepository repository)
        {
            _repository = repository;
        }

            public List<SubCityMasterEntity> GetAll(string language)
        {
            List<SubCityMasterEntity> results = this._repository.GetAll(language);
            return results;
        }
        public string Delete(int subCityId)
        {
            if (subCityId != 0)
            {
                var result = _repository.Delete(subCityId);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
        }
        private string Validate(SubCityMasterEntity entity)
        {
            if (entity.SubCityName == String.Empty)
            {
                return "Subcity  name can not be empty";
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

        public string Save(SubCityMasterEntity subcity, string? selectedLanguage)
        {
            try
            {
                string msg = Validate(subcity);
                if (msg != String.Empty)
                {
                    return msg;
                }
                else
                {
                    bool result = _repository.Save(subcity, selectedLanguage);
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


    }
}
