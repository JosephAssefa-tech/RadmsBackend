using Microsoft.EntityFrameworkCore;
using RadmsDataAccessLogic;
using RadmsDataModels.Modelss;
using RadmsEntities;
using RadmsRepositoryFacade.IAsync;
using RadmsRepositoryFacade.Specifications;
using RadmsRepositoryManager.Evaluator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsRepositoryManager.BaseRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        RadmsContext context = new RadmsContext();
   

        public bool Delete(decimal id)
        {
            throw new NotImplementedException();
        }

        public T FilterByAccidentName(string CauseName)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            List<T> models = context.Set<T>().ToList();
            List<T> entities = new List<T>();
            foreach (var model in models)
            {

                T entity = (T)Activator.CreateInstance(typeof(T), model);


                entities.Add(entity);
            }
            return entities;
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
