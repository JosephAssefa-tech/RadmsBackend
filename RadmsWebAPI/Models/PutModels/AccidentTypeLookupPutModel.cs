using RadmsEntities;

namespace RadmsWebAPI.Models.PutModels
{
    public class AccidentTypeLookupPutModel
    {
        public int AccidentTypeId { get; set; }

        public string AccidentType { get; set; } = null!;
        public AccidentTypeLookupPutModel()
        {

        }
        public AccidentTypeLookupPutModel(AccidentTypeLookupEntity entity)
        {
            this.AccidentTypeId= entity.AccidentTypeId;
            this.AccidentType = entity.AccidentType;
        }
        public T MapToViewEntity<T>() where T : class
        {
            AccidentTypeLookupEntity entity = new AccidentTypeLookupEntity();
            entity.AccidentTypeId = this.AccidentTypeId;
            entity.AccidentType = this.AccidentType;

            return entity as T;


        }

    }
}
