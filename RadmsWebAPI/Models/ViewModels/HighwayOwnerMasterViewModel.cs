using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class HighwayOwnerMasterViewModel
    {
        public string HownerId { get; set; } = null!;

        public string HownerName { get; set; } = null!;
        public HighwayOwnerMasterViewModel()
        {

        }
        public HighwayOwnerMasterViewModel(HighwayOwnerMasterEntity entity)
         {
             this.HownerId = entity.HownerId;
            this.HownerName = entity.HownerName;
         }
        public T MapToViewEntity<T>() where T : class
        {
            HighwayOwnerMasterEntity model = new HighwayOwnerMasterEntity();
            model.HownerId = this.HownerId;
            model.HownerName = this.HownerName;
            return model as T;
        }
    }

}
