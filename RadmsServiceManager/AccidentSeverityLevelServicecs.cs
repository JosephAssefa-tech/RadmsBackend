using RadmsEntities;
using RadmsRepositoryFacade;
using RadmsServiceFacade;


namespace RadmsServiceManager
{
    public class AccidentSeverityLevelServicecs : IAccidentSeverityLevelServicecs
    {
        IAccidentSeverityLevelRepository _service;
        public AccidentSeverityLevelServicecs(IAccidentSeverityLevelRepository service)
        {
            _service = service;
        }
        public List<SeverityLevelLookupEntity> GetAll()
        {
            List<SeverityLevelLookupEntity> results = this._service.GetAll();
            return results;
        }
    }
}
