using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface  ISubCityMasterService
    {
        List<SubCityMasterEntity> GetAll(string language);
        string Delete(int subCityId);
        string Save(SubCityMasterEntity subcity, string? selectedLanguage);
    }
}
