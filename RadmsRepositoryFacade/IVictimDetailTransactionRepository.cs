﻿using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface IVictimDetailTransactionRepository
    {
        VictimDetailsTransactionEntity GetById(int id);
        VictimDetailsTransactionEntity FilterByAccidentName(string CauseName);
        bool Save(VictimDetailsTransactionEntity accident);
        bool Update(VictimDetailsTransactionEntity accident);
        bool Delete(decimal id);
        List<VictimDetailsTransactionEntity> GetAll();
    }
}
