using RadmsEntities;
using RadmsRepositoryFacade;
using RadmsServiceFacade;


namespace RadmsServiceManager
{
    public class AccidentSeverityLevelServicecs : IAccidentSeverityLevelServicecs
    {
        IAccidentSeverityLevelRepository _repository;
        public AccidentSeverityLevelServicecs(IAccidentSeverityLevelRepository repository)
        {
            _repository = repository;
        }

        public string Delete(int severityId)
        {
            if (severityId != 0)
            {
                var result = _repository.Delete(severityId);

                return "sucessfuly deleted";

            }
            else
            {
                return "can't delete b/c accident cause id is not given";
            }
        }

        public List<SeverityLevelLookupEntity> GetAll(string? language)
        {
            List<SeverityLevelLookupEntity> results = this._repository.GetAll(language);
            return results;
        }
        private string Validate(SeverityLevelLookupEntity entity)
        {
            if (entity.SeverityType == String.Empty)
            {
                return "SeverityType  name can not be empty";
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
        public string Save(SeverityLevelLookupEntity entity)
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
                    bool result = _repository.Save(entity);
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

        public string Update(SeverityLevelLookupEntity entity)
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
                    bool result = _repository.Update(entity);
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
