using RadmsEntities;

namespace RadmsWebAPI.Models.PutModels
{
    public class ImpactTypeLookupUpdateModel
    {
        public int ImpactTypeId { get; set; }

        public string ImpactTypeName { get; set; } = null!;
       public ImpactTypeLookupUpdateModel()
        {

        }
        public ImpactTypeLookupUpdateModel(ImpactTypeLookupEntity entity)
        {
            this.ImpactTypeId = entity.ImpactTypeId;
            this.ImpactTypeName= entity.ImpactTypeName; 
        }
        public T MapToViewEntity<T>() where T : class
        {
            ImpactTypeLookupEntity model = new ImpactTypeLookupEntity();
            model.ImpactTypeId = this.ImpactTypeId;
            model.ImpactTypeName = this.ImpactTypeName;

            return model as T;
        }
    }
}
