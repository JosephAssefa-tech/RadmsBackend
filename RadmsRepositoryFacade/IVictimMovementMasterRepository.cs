﻿using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface  IVictimMovementMasterRepository
    {
        List<VictimMovementMasterEntity> GetAll();
    }
}
