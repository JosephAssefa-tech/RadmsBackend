using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class PedestrianMovementLookupViewModel
    {
        public int PedestrianMovementId { get; set; }

        public string PedestrianMovementName { get; set; } = null!;
        public PedestrianMovementLookupViewModel()
        {

        }
        public PedestrianMovementLookupViewModel(PedestrianMovementLookupEntity entity)
        {
            this.PedestrianMovementId = entity.PedestrianMovementId;
            this.PedestrianMovementName = entity.PedestrianMovementName;

        }
        public T MapToViewEntity<T>() where T : class
        {
            PedestrianMovementLookupEntity entity = new PedestrianMovementLookupEntity();
            entity.PedestrianMovementId = this.PedestrianMovementId;
            entity.PedestrianMovementName = this.PedestrianMovementName;
            return entity as T;
        }

    }
}
