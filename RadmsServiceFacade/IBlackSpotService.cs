﻿using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface  IBlackSpotService
    {
        List<BlackSpotMasterEntity> GetAll(DateTime? startDate,DateTime? endDate);
        int GetTotalBlackspotCount();
    }
}
