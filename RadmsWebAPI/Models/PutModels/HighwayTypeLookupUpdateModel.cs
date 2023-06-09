using RadmsEntities;

namespace RadmsWebAPI.Models.PutModels
{
    public class HighwayTypeLookupUpdateModel
    {
        public int HtypeId { get; set; }
        public string HtypeName { get; set; } = null!;
       public HighwayTypeLookupUpdateModel()
        {

        }
        public HighwayTypeLookupUpdateModel(HighwayTypeLookupEntity entity)
        {
            this.HtypeId = entity.HtypeId;
            this.HtypeName = entity.HtypeName;

        }
        public T MapToViewEntity<T>() where T : class
        {
            HighwayTypeLookupEntity model = new HighwayTypeLookupEntity();
            model.HtypeId = this.HtypeId;
            model.HtypeName = this.HtypeName;

            return model as T;
        }
    }
}
