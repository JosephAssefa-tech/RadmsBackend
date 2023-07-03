using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface IZoneMasterService
    {
        List<ZoneMasterEntity> GetAll(string language,int? regionId);
        string Delete(int zoneId);
        string Update(ZoneMasterEntity accident);
        string Save(ZoneMasterEntity accident, string? selectedLanguage);
    }
}
