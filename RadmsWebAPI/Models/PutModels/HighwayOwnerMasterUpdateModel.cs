using RadmsEntities;

namespace RadmsWebAPI.Models.PutModels
{
    public class HighwayOwnerMasterUpdateModel
    {
        public string HownerId { get; set; } = null!;

        public string HownerName { get; set; } = null!;
        public HighwayOwnerMasterUpdateModel()
        {

        }
        public HighwayOwnerMasterUpdateModel(HighwayOwnerMasterEntity entity)
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
