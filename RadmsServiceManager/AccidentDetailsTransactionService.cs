﻿using RadmsEntities;
using RadmsRepositoryFacade;
using RadmsServiceFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceManager
{
    public class AccidentDetailsTransactionService : IAccidentDetailsTransaction
    {
        IAccidentDetailsTransactionRepository _repository;
            public AccidentDetailsTransactionService(IAccidentDetailsTransactionRepository repository)
        {
            _repository = repository;
        }
        public string Delete(decimal id )
        {
            if (id!= 0)
            {
                var result = _repository.Delete(id);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
        }

        public AccidentDetailsTransactionEntity FilterByAccidentName(string CauseName)
        {
            throw new NotImplementedException();
        }

        public List<AccidentDetailsTransactionEntity> GetAll()
        {
            List<AccidentDetailsTransactionEntity> results = this._repository.GetAll();
            return results;
        }

        public AccidentDetailsTransactionEntity GetById(int id)
        {
            var result = _repository.GetById(id);
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new Exception();
            }
        }
        private string Validate(AccidentDetailsTransactionEntity entity)
        {
            if (entity.AccidentLocalName == String.Empty)
            {
                return "Accident location name can not be empty";
            }
            //else if(entity.startDate>entity.endDate)
            //{
            //    return "start date can't be greater than end date";
            //}
            else
            {
                return string.Empty;
            }

        }

        public string Save(AccidentDetailsTransactionEntity accident)
        {
            try
            {
                string msg = Validate(accident);
                if (msg != String.Empty)
                {
                    return msg;
                }
                else
                {
    //               namespace AutoIncrementIDExample
    //{
    //    public class AutoIncrementIDGenerator
    //    {
    //        private readonly DbContext _dbContext;

    //        public AutoIncrementIDGenerator(DbContext dbContext)
    //        {
    //            _dbContext = dbContext;
    //        }

    //        public async Task<string> GenerateAutoIncrementID()
    //        {
    //            var now = DateTime.Now;
    //            var prefix = now.ToString("yyyyMMddHHmmss");
    //            var lastNumber = await _dbContext.Set<AutoIncrementID>()
    //                .OrderByDescending(x => x.ID)
    //                .Select(x => x.ID)
    //                .FirstOrDefaultAsync();
    //            var nextNumber = lastNumber + 1;
    //            var id = $"{prefix}{nextNumber:D6}";
    //            _dbContext.Set<AutoIncrementID>().Add(new AutoIncrementID { ID = nextNumber });
    //            await _dbContext.SaveChangesAsync();
    //            return id;
    //        }
    //    }

    //    public class AutoIncrementID
    //    {
    //        public int ID { get; set; }
    //    }
    //}

    bool result = _repository.SaveAsync(accident);
                    if (result == true)
                    {
                        return "saved sucessfuly";
                    }
                    else
                    {
                        return "unkown error occured";

                    }
                }

            }
            catch (Exception)
            {
                throw;

            }
        }

        public string Update(AccidentDetailsTransactionEntity accident)
        {
            try
            {
                string msg = Validate(accident);
                if (msg != String.Empty)
                {
                    return msg;
                }
                else
                {
                    bool result = _repository.Update(accident);
                    if (result == true)
                    {
                        return "Updated sucessfuly";
                    }
                    else
                    {
                        return "unkown error occured";

                    }
                }

            }
            catch (Exception)
            {
                throw;

            }
        }
    }
}
