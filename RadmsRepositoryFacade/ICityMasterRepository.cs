﻿using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface ICityMasterRepository
    {
        List<CityMasterEntity> GetAll(string language);
        bool Delete(int cityId);
        bool Save(CityMasterEntity city, string? selectedLanguage);
    }
}
