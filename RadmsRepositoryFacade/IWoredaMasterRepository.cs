using RadmsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade
{
    public interface  IWoredaMasterRepository
    {
        List<WoredaMasterEntity> GetAll(string language);
        string Save(WoredaMasterEntity accident, string language);
        bool Delete(int woredaId);
        bool Update(WoredaMasterEntity entity);
    }
}
