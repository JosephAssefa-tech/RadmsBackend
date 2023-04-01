using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class CollisionTypeLookupViewModel
    {
        public int CollisionTypeId { get; set; }

        public string CollisionTypeName { get; set; } = null!;

        public CollisionTypeLookupViewModel()
        {

        }
        public CollisionTypeLookupViewModel(CollisionTypeLookupEntity entity)
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
