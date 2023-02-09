using RadmsEntities;
using RadmsRepositoryFacade;
using RadmsServiceFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceManager
{
    public class AccidentServiceComplete : IAccidentService, IAccidentServiceCRUD
    {
        IAccidentRepository _repository;
        public AccidentServiceComplete(IAccidentRepository repository)
        {
            _repository = repository;
        }
        //public List<AccidentCauseLookupEntity> GetByDateRange(DateTime startDate,DateTime endDate)
        //{
        //    List<AccidentCauseLookupEntity> entities = this._repository.GetByDateRange(startDate, endDate);
        //    return entities;
        //}

        public string Delete(AccidentCauseLookupEntity accident)
        {
            throw new NotImplementedException();
        }

        public AccidentCauseLookupEntity FilterByAccidentName(string CauseName)
        {
            throw new NotImplementedException();
        }

        public List<AccidentCauseLookupEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public AccidentCauseLookupEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public string Save(AccidentCauseLookupEntity accident)
        {
            throw new NotImplementedException();
        }

        public string Update(AccidentCauseLookupEntity accident)
        {
            throw new NotImplementedException();
        }
    }
}
