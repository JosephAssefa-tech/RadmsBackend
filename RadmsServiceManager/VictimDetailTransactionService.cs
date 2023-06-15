using Microsoft.EntityFrameworkCore;
using RadmsDataAccessLogic;
using RadmsDataModels.Modelss;
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
        private readonly IRepository<AccidentDetailsTransaction> _accidentClassRepository;
        public VictimDetailTransactionService(IRepository<AccidentDetailsTransaction> accidentClassRepository,IVictimDetailTransactionRepository repository, IRepository<VictimDetailsTransaction> otherClassRepository)
        {
            _repository = repository;
            _otherClassRepository = otherClassRepository;
            _accidentClassRepository=accidentClassRepository;
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

        public async Task<IEnumerable<SummaryData>> GetGroupedDataAsync(DateTime? startDate = null, DateTime? endDate = null)
        {
            var currentYear = DateTime.Now.Year;
            var query = _otherClassRepository.Query();

            var joinedQuery = query.Join(
                _accidentClassRepository.Query(), // Joining with AccidentDetailsTransaction table
                o => o.AccidentId,
                ad => ad.AccidentId,
                (o, ad) => new { o, ad }
            );

            if (startDate != null && endDate != null)
            {
                joinedQuery = joinedQuery.Where(x => x.ad.DateAndTime >= startDate && x.ad.DateAndTime <= endDate);
            }

            var groupedData = await joinedQuery
                .Select(x => new { x.o.Severity.SeverityId, x.o.Severity.SeverityType })
                .GroupBy(x => new { x.SeverityId, x.SeverityType })
                .Select(g => new SummaryData
                {
                    Year = currentYear,
                    SeverityId = g.Key.SeverityId,
                    SeverityType = g.Key.SeverityType,
                    Count = g.Count()
                })
                .ToListAsync();

            if (groupedData.Count == 0)
            {
                groupedData.Add(new SummaryData { Year = currentYear, SeverityId = 2, SeverityType = "Type 3", Count = 0 });
                groupedData.Add(new SummaryData { Year = currentYear, SeverityId = 3, SeverityType = "Type 4", Count = 0 });
                groupedData.Add(new SummaryData { Year = currentYear, SeverityId = 4, SeverityType = "Type 4", Count = 0 });

            }

            return groupedData;
        }




        public List<SummaryData> GetSummaryWithDateAndRegion(int? regionId, DateTime? startDate, DateTime? endDate)
        {
            try
            {
               
             

                var result = _repository.GetSummaryWithDateAndRegion(regionId,startDate,endDate);
            
                return result;
        

            }
            catch (Exception)
            {
                throw;

            }
        }
        public async Task<int> GetFatalAccidentCount(int year, DateTime? startDate, DateTime? endDate)
        {
            return await _repository.GetFatalAccidentCount(year, startDate, endDate);
        }

        public async Task<int> GetSeriousAccidentCount(int year, DateTime? startDate, DateTime? endDate)
        {
            return await _repository.GetSeriousAccidentCount(year, startDate, endDate);
        }

        public async Task<int> GetSlightAccidentCount(int year, DateTime? startDate, DateTime? endDate)
        {
            return await _repository.GetSlightAccidentCount(year, startDate, endDate);
        }

        public async Task<int> GetPropertyDamageCount(int year, DateTime? startDate, DateTime? endDate)
        {
            return await _repository.GetPropertyDamageCount(year, startDate, endDate);
        }


    }
}
