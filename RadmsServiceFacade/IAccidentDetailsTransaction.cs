﻿using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceFacade
{
    public interface IAccidentDetailsTransaction
    {
        AccidentDetailsTransactionEntity GetById(int id);
        AccidentDetailsTransactionEntity FilterByAccidentName(string CauseName);
        string Save(AccidentDetailsTransactionEntity accident);
        string Update(AccidentDetailsTransactionEntity accident);
        string Delete(AccidentDetailsTransactionEntity accident);
        List<AccidentDetailsTransactionEntity> GetAll();

    }
}
