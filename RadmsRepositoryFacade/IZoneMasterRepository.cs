using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface IZoneMasterRepository
    {
        List<ZoneMasterEntity> GetAll(string language,int? regionId);
        bool Update(ZoneMasterEntity accident);
        bool Save(ZoneMasterEntity accident, string? selectedLanguage);
        bool Delete(int zoneId);
    }
}
