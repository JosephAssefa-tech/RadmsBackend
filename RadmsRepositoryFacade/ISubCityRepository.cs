using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface ISubCityRepository
    {
        List<SubCityMasterEntity> GetAll(string language);
        bool Delete(int subCityId);
        bool Save(SubCityMasterEntity subcity, string? selectedLanguage);

    }
}
