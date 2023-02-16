using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class AccidentTypeLookupViewModel
    {
        public int AccidentTypeId { get; set; }

        public string AccidentType { get; set; } = null!;
        public AccidentTypeLookupViewModel()
        {

        }
        public AccidentTypeLookupViewModel(AccidentTypeLookupEntity entity)
        {
            AccidentTypeId=entity.AccidentTypeId;
            AccidentType=entity.AccidentType;

        }
        public T MapToViewEntity<T>() where T : class
        {
            AccidentTypeLookupEntity entity = new AccidentTypeLookupEntity();
            entity.AccidentTypeId = AccidentTypeId;
            entity.AccidentType = AccidentType;


            return entity as T;

        }

    }
}
