using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities.BaseEntity
{
    public interface RadmsBaseEntity
    {
        T MapToModel<T>() where T : class;
    }
}
