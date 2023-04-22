using RadmsDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class BlackSpotMasterEntity
    {
       
        public int BlackSpotId { get; set; }
        public double BlackSpotLat { get; set; }
        public double BlackSpotLong { get; set; }

        public decimal? AccidentId { get; set; }

        public BlackSpotMasterEntity()
        {

        }
        public BlackSpotMasterEntity(BlackSpotMaster model)
        {
            this.BlackSpotId = model.BlackSpotId;
            this.BlackSpotLat = model.BlackSpotLat;
            this.BlackSpotLong = model.BlackSpotLong;
            this.AccidentId = model.AccidentId;

        }
        public T MapToModel<T>() where T : class
        {
            BlackSpotMaster model = new BlackSpotMaster();
            model.BlackSpotId = this.BlackSpotId;
            model.BlackSpotLat = this.BlackSpotLat;
            model.BlackSpotLong = this.BlackSpotLong;
            model.AccidentId = this.AccidentId;
            return model as T;
        }

    }
}
