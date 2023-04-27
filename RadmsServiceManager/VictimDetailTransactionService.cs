using Microsoft.EntityFrameworkCore;
using RadmsDataAccessLogic;
using RadmsDataModels.Models;
using RadmsEntities;
using RadmsRepositoryFacade;
using RadmsRepositoryFacade.BaseRepositoryFacade;
using RadmsServiceFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsServiceManager
{
    public class VictimDetailTransactionService : IVictimDetailTransaction
    {
      RadmsContext context =new RadmsContext();
        IVictimDetailTransactionRepository _repository;
        private readonly IRepository<VictimDetailsTransaction> _otherClassRepository;
        public VictimDetailTransactionService(IVictimDetailTransactionRepository repository, IRepository<VictimDetailsTransaction> otherClassRepository)
        {
            _repository = repository;
            _otherClassRepository = otherClassRepository;
        }


        public string Delete(decimal id)
        {
            throw new NotImplementedException();
        }

        public VictimDetailsTransactionEntity FilterByAccidentName(string CauseName)
        {
            throw new NotImplementedException();
        }

        public List<VictimDetailsTransactionEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public VictimDetailsTransactionEntity GetById(int id)
        {
            throw new NotImplementedException();
        }
        private string Validate(VictimDetailsTransactionEntity entity)
        {
            if (entity.VictimName == String.Empty)
            {
                return "Victim name can not be empty";
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
        public string Save(VictimDetailsTransactionEntity victim)
        {
            try
            {
                string msg = Validate(victim);
                if (msg != String.Empty)
                {
                    return msg;
                }
                else
                {


                    bool result = _repository.Save(victim);
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


        public string Update(VictimDetailsTransactionEntity victim)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SummaryData>> GetGroupedDataAsync()
        {
            var currentYear = DateTime.Now.Year;
            var query =  _otherClassRepository.Query();
                ;

                var groupedData= await query.Include(o => o.Severity).GroupBy(o => new { o.Severity.SeverityId, o.Severity.SeverityType })
                .Select(g => new SummaryData
                {
                    Year=currentYear,
                    SeverityId = g.Key.SeverityId,
                    SeverityType = g.Key.SeverityType,
                    Count = g.Count()
                    
                })
                .ToListAsync();

            return groupedData;
        }
        public List<SummaryData> GetSummaryWithDateAndRegion(int? regionId, DateTime? dateTime)
        {
            try
            {
               
             

                var result = _repository.GetSummaryWithDateAndRegion(regionId,dateTime);
            
                return result;
        

            }
            catch (Exception)
            {
                throw;

            }
        }


    }
}
