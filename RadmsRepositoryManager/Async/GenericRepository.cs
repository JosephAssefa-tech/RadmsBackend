//using Microsoft.EntityFrameworkCore;
//using RadmsDataAccessLogic;
//using RadmsDataModels.Models;
//using RadmsEntities;
//using RadmsRepositoryFacade.IAsync;
//using RadmsRepositoryFacade.Specifications;
//using RadmsRepositoryManager.Evaluator;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace RadmsRepositoryManager.Async
//{
//    public class GenericRepository<T> : IGenericRepository<T> where T : class
//    {
//        private readonly RadmsContext _context;
//        public GenericRepository(RadmsContext context)
//        {
//            _context = context;
//        }

//        public async Task<AccidentCauseLookup> GetByIdAsync(int id)
//        {
//            return await _context.Set<AccidentCauseLookup>().FindAsync(id);

//        }
//        public async Task<IReadOnlyList<AccidentCauseLookup>> GetAllAsync()
//        {
//            return await _context.Set<AccidentCauseLookup>().ToListAsync();

//        }

//        //public async Task<AccidentCauseLookup> GetWithSpec(ISpecification<T> spec)
//        //{
//        //    return await ApplySpecification(spec).FirstOrDefaultAsync();


//        //}

//        public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
//        {
//            return await ApplySpecification(spec).ToListAsync();
//        }
//        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
//        {
//            return SpecificationEvaluator<T>.GetQuery(_context.Set<T>().AsQueryable(), spec);
//        }

//        Task<T> IGenericRepository<T>.GetByIdAsync(int id)
//        {
//            throw new NotImplementedException();
//        }

//        Task<IReadOnlyList<T>> IGenericRepository<T>.GetAllAsync()
//        {
//            throw new NotImplementedException();
//        }

//        public Task<T> GetWithSpec(ISpecification<T> spec)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
