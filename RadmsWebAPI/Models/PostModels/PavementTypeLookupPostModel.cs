using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class PavementTypeLookupPostModel
    {
        public int PavementTypeId { get; set; }

        public string PavementName { get; set; } = null!;
        public PavementTypeLookupPostModel()
        {

        }
        public PavementTypeLookupPostModel(PavementTypeLookupEntity entity)
        {
            this.PavementTypeId = entity.PavementTypeId;
            this.PavementName = entity.PavementName;

        }
        public T MapToViewEntity<T>() where T : class
        {
            PavementTypeLookupEntity entity = new PavementTypeLookupEntity();
            entity.PavementTypeId = this.PavementTypeId;
            entity.PavementName = this.PavementName;
            //entity.Region = this.Region.MapToViewEntity<RegionMasterEntity>(); ;
            return entity as T;


        }

    }
}
