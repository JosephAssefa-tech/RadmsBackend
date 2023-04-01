using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class ImpactTypeLookupViewModel
    {
        public int ImpactTypeId { get; set; }

        public string ImpactTypeName { get; set; } = null!;
       public ImpactTypeLookupViewModel()
        {

        }
        public ImpactTypeLookupViewModel(ImpactTypeLookupEntity entity)
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
