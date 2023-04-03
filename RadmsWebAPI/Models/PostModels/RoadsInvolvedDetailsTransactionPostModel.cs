using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class RoadsInvolvedDetailsTransactionPostModel
    {
        public int RoadInvolvedId {get;set;}
        public decimal? AccidentId { get; set; }

        public string Hid { get; set; } = null!;

        public int PavementTypeId { get; set; }

        public int RoadSurfaceId { get; set; }

        public int RoadCarriagewayId { get; set; }

        //[ForeignKey("AccidentId")]
        //   public virtual AccidentDetailsTransactionEntity? Accident { get; set; }
        //[ForeignKey("Hid")]
        //    public virtual HighwayMasterEntity HidNavigation { get; set; } = null!;
        //[ForeignKey("PavementTypeId")]
        //    public virtual PavementTypeLookupEntity PavementType { get; set; } = null!;
        //[ForeignKey("RoadCarriagewayId")]
        //    public virtual RoadCarriagewayTypeLookupEntity RoadCarriageway { get; set; } = null!;
        //[ForeignKey("RoadSurfaceId")]
        //    public virtual RoadSurfaceConditionLookupEntity RoadSurface { get; set; } = null!;
        public RoadsInvolvedDetailsTransactionPostModel()
        {

        }
        public RoadsInvolvedDetailsTransactionPostModel(RoadsInvolvedDetailsTransactionEntity entity)
        {
            this.RoadInvolvedId = entity.RoadInvolvedId;
            this.AccidentId = entity.AccidentId;
            this.Hid = entity.Hid;
            this.PavementTypeId = entity.PavementTypeId;
            this.RoadSurfaceId = entity.RoadSurfaceId;
            this.RoadCarriagewayId = entity.RoadCarriagewayId;

        }
        public T MapToViewEntity<T>() where T : class
        {
            RoadsInvolvedDetailsTransactionEntity entity = new RoadsInvolvedDetailsTransactionEntity();
            entity.RoadInvolvedId = this.RoadInvolvedId;
            entity.AccidentId = this.AccidentId;
            entity.Hid = this.Hid;
            entity.PavementTypeId = this.PavementTypeId;
            entity.RoadSurfaceId = this.RoadSurfaceId;
            entity.RoadCarriagewayId = this.RoadCarriagewayId;

            return entity as T;
        }
    }
}
