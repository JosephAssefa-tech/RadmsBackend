using RadmsEntities;
using RadmsRepositoryFacade.IAsync;
using RadmsServiceFacade.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceManager.NewFolder
{
    public class GenericService<T> : IGenericService<AccidentCauseLookupEntity>
    {
        IGenericRepository<AccidentCauseLookupEntity> _iservice;
        public GenericService(IGenericRepository<AccidentCauseLookupEntity> iservice)
            {
            this._iservice = iservice;

            }
        public async Task<IReadOnlyList<AccidentCauseLookupEntity>> GetAllAsync()
        {
            return await _iservice.GetAllAsync();
        }

        public Task<AccidentCauseLookupEntity> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
