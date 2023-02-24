using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class HighwayTypeLookupPostModel
    {
        public int HtypeId { get; set; }
        public string HtypeName { get; set; } = null!;
       public HighwayTypeLookupPostModel()
        {

        }
        public HighwayTypeLookupPostModel(HighwayTypeLookupEntity entity)
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
