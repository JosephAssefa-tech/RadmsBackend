﻿using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface IAccidentDetailsTransactionRepository
    {
        bool Save(AccidentDetailsTransactionEntity accident);
        bool Update(AccidentDetailsTransactionEntity accident);
        bool Delete(AccidentDetailsTransactionEntity accident);
        List<AccidentDetailsTransactionEntity> GetAll();
        AccidentDetailsTransactionEntity GetById(int id);
        AccidentDetailsTransactionEntity FilterByAccidentName(string CauseName);
    }
}
