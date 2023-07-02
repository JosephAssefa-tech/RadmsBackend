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
    public class CourtCaseTransactionService : ICourtCaseTransactionService
    {
        ICourtCaseTransactionRepository _repositiory;
        public CourtCaseTransactionService(ICourtCaseTransactionRepository repositiory)
        {
            _repositiory = repositiory;

        }
        public string Delete(int ID)
        {
            if (ID != 0)
            {
                var result = _repositiory.Delete(ID);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
        }

        public List<CourtCaseTransactionEntities> GetAll(string? language)
        {
            throw new NotImplementedException();
        }
        private string Validate(CourtCaseTransactionEntities entity)
        {
            if (entity.PenaltyAmount == null)
            {
                return "PenaltyAmount  name can not be empty";
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

        public string Save(CourtCaseTransactionEntities entity)
        {
            try
            {
                string msg = Validate(entity);
                if (msg != String.Empty)
                {
                    return msg;
                }
                else
                {
                    bool result = _repositiory.Save(entity);
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

        public string Update(CourtCaseTransactionEntities entity)
        {
            throw new NotImplementedException();
        }
    }
}
