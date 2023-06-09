using RadmsEntities;

namespace RadmsWebAPI.Models.PutModels
{
    public class CollisionTypeLookupUpdateModel
    {
        public int CollisionTypeId { get; set; }

        public string CollisionTypeName { get; set; } = null!;

        public CollisionTypeLookupUpdateModel()
        {

        }
        public CollisionTypeLookupUpdateModel(CollisionTypeLookupEntity entity)
        {
            this.CollisionTypeId = entity.CollisionTypeId;
            this.CollisionTypeName = entity.CollisionTypeName;

        }
        public T MapToViewEntity<T>() where T : class
        {
            CollisionTypeLookupEntity model = new CollisionTypeLookupEntity();
            model.CollisionTypeId = this.CollisionTypeId;
            model.CollisionTypeId = this.CollisionTypeId;
            return model as T;
        }
    }
}
