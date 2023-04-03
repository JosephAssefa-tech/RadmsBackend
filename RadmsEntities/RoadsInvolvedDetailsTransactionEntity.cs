using RadmsDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class RoadsInvolvedDetailsTransactionEntity
    {
        public int RoadInvolvedId { get; set; }
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
        public RoadsInvolvedDetailsTransactionEntity()
        {

        }
        public RoadsInvolvedDetailsTransactionEntity(RoadsInvolvedDetailsTransaction model)
        {
            this.RoadInvolvedId =model.RoadInvolvedId;
            this.AccidentId = model.AccidentId;
            this.Hid = model.Hid;
            this.PavementTypeId = model.PavementTypeId;
            this.RoadSurfaceId = model.RoadSurfaceId;
            this.RoadCarriagewayId = model.RoadCarriagewayId;

        }






        public T MapToModel<T>() where T : class
        {
            RoadsInvolvedDetailsTransaction model = new RoadsInvolvedDetailsTransaction();

            model.RoadInvolvedId = this.RoadInvolvedId;
            model.AccidentId = this.AccidentId;
            model.Hid = this.Hid;
            model.PavementTypeId = this.PavementTypeId;
            model.RoadSurfaceId = this.RoadSurfaceId;
            model.RoadCarriagewayId = this.RoadCarriagewayId;
    

            return model as T;

        }
    }
}
