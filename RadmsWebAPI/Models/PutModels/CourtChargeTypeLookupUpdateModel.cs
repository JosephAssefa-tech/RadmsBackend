using RadmsEntities;

namespace RadmsWebAPI.Models.PutModels
{
    public class CourtChargeTypeLookupUpdateModel
    {
        public int CourtChargeID { get; set; }
        public string CourtChargeType { get; set; }
        public CourtChargeTypeLookupUpdateModel()
       {

       }
        public CourtChargeTypeLookupUpdateModel(CourtChargeTypeLookupEntity entity)
        {
            this.CourtChargeID = entity.CourtChargeID;
            this.CourtChargeType = entity.CourtChargeType;

        }
        public T MapToViewEntity<T>() where T : class
        {
            CourtChargeTypeLookupEntity entity = new CourtChargeTypeLookupEntity();
            entity.CourtChargeID = this.CourtChargeID;
            entity.CourtChargeType = this.CourtChargeType;


            return entity as T;
        }
    }
}
