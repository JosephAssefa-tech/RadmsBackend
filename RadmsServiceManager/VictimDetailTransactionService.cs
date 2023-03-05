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
    public class VictimDetailTransactionService : IVictimDetailTransaction
    {
        IVictimDetailTransactionRepository _repository;
        public VictimDetailTransactionService(IVictimDetailTransactionRepository repository)
        {
            _repository = repository;
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
    }
}
