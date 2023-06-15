﻿using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface IBlackSpotRepository
    {
        List<BlackSpotMasterEntity> GetAll(DateTime? startDate,DateTime? endDate);
        int GetBlackspotCount();
    }
}
