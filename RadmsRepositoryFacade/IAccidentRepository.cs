﻿using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface IAccidentRepository
    {
        bool Save(AccidentCauseLookupEntity accident);
        bool Update(AccidentCauseLookupEntity accident);
        bool Delete(AccidentCauseLookupEntity accident);
        List<AccidentCauseLookupEntity> GetAll();
        AccidentCauseLookupEntity GetById(int id);
        List<AccidentCauseLookupEntity> FilterByDateRange(DateTime startDate, DateTime endDate);




    }
}
