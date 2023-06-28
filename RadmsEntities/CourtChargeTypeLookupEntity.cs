using RadmsDataModels.Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class CourtChargeTypeLookupEntity
    {
        public int CourtChargeID { get; set; }
        public string CourtChargeType { get; set; }
        public CourtChargeTypeLookupEntity()
        {

        }
        public CourtChargeTypeLookupEntity(CourtChargeTypeLookup model)
        {
            this.CourtChargeID = model.CourtChargeID;   
            this.CourtChargeType = model.CourtChargeType;

        }
        public T MapToModel<T>() where T : class
        {
            CourtChargeTypeLookup model = new CourtChargeTypeLookup();
            model.CourtChargeID = this.CourtChargeID;
            model.CourtChargeType = this.CourtChargeType;
            return model as T;
        }
    }
}
