using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using RadmsDataModels.Modelss;

namespace RadmsEntities
{

    public  class HighwayMasterEntity
    {
        public HighwayMasterEntity()
        {
          AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
        }


        public string Hid { get; set; } = null!;

        public string Hname { get; set; } = null!;

     // public int? HtypeId { get; set; }

    // public string? HownerId { get; set; }
        public int? Hlength { get; set; }
        public int? StartChange { get; set; }
        public int? EndChanage { get; set; }

        public virtual HighwayOwnerMasterEntity? Howner { get; set; }

        public virtual HighwayTypeLookupEntity? Htype { get; set; }
        public HighwayMasterEntity(HighwayMaster model)
        {
            this.Hid = model.Hid;
            this.Hname = model.Hname;
            //this.Hlength = model.Hlength;
            //this.StartChange = model.StartChange;
            //this.EndChanage = model.EndChanage;
            // this.HtypeId = model.HtypeId;
            //this.Howner = new HighwayOwnerMasterEntity(model.Howner);
            //this.Htype = new HighwayTypeLookupEntity(model.Htype);

        }
        public T MapToModel<T>() where T : class
        {
            HighwayMaster model = new HighwayMaster();
            model.Hid = this.Hid;
            model.Hname = this.Hname;
            //model.Hlength = this.Hlength;
            //model.StartChange = this.StartChange;
            //model.EndChanage = this.EndChanage;
           // model.Howner=new HighwayOwnerMasterEntity(MapToModel<HighwayOwnerMaster>())
            return model as T;
        }
        public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }
    }
}
