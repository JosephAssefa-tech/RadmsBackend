﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryFacade.BaseRepositoryFacade
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Query();
    }
}
