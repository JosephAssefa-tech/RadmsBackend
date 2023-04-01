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
    public class LegalMeasurementDetailsTransactionService : ILegalMeasurementDetailsTransaction
    {
        ILegalMeasurementDetailsTransactionRepository _repository;
        public LegalMeasurementDetailsTransactionService(ILegalMeasurementDetailsTransactionRepository repository)
        {
            _repository = repository;
        }
        public string Delete(decimal id)
        {
            throw new NotImplementedException();
        }

        public LegalMeasurementDetailsTransactionEntity FilterByAccidentName(string CauseName)
        {
            throw new NotImplementedException();
        }

        public List<LegalMeasurementDetailsTransactionEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public LegalMeasurementDetailsTransactionEntity GetById(int id)
        {
            throw new NotImplementedException();
        }
        private string Validate(LegalMeasurementDetailsTransactionEntity entity)
        {
            if (entity.IsDeadFile != false)
            {
                return "IsDeadFile can not be empty";
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
        public string Save(LegalMeasurementDetailsTransactionEntity legal)
        {
            //  try
            //  {
            //string msg = Validate(legal);
            //if (msg != String.Empty)
            //{
            //    return msg;
            //}
            //else
            //{


            bool result = _repository.Save(legal);
            if (result == true)
            {
                return "saved sucessfuly";
        }
                    else
                    {
                        return "unkown error occured";

                    }
               // }

           // }
           // catch (Exception)
           // {
           //     throw;

           // }
        }

        public string Update(LegalMeasurementDetailsTransactionEntity victim)
        {
            throw new NotImplementedException();
        }
    }
}
