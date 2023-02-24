using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class ImpactTypeLookupPostModel
    {
        public int ImpactTypeId { get; set; }

        public string ImpactTypeName { get; set; } = null!;
       public ImpactTypeLookupPostModel()
        {

        }
        public ImpactTypeLookupPostModel(ImpactTypeLookupEntity entity)
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
