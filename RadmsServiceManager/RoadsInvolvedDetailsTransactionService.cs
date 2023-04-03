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
    public class RoadsInvolvedDetailsTransactionService : IRoadsInvolvedDetailsTransactionService
    {
        IRoadsInvolvedDetailsTransactionRepository _repository;
        public RoadsInvolvedDetailsTransactionService(IRoadsInvolvedDetailsTransactionRepository repository)
        {
            _repository = repository;
        }
        public string Delete(decimal id)
        {
            throw new NotImplementedException();
        }

        public RoadsInvolvedDetailsTransactionEntity FilterByAccidentName(string CauseName)
        {
            throw new NotImplementedException();
        }

        public List<RoadsInvolvedDetailsTransactionEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public RoadsInvolvedDetailsTransactionEntity GetById(int id)
        {
            throw new NotImplementedException();
        }
        private string Validate(RoadsInvolvedDetailsTransactionEntity entity)
        {
            if (entity.RoadSurfaceId == null)
            {
                return " name can not be empty";
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

        public string Save(RoadsInvolvedDetailsTransactionEntity accident)
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


                    bool result = _repository.Save(accident);
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

        public string Update(RoadsInvolvedDetailsTransactionEntity accident)
        {
            throw new NotImplementedException();
        }
    }
}
