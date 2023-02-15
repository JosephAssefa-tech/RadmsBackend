﻿using RadmsDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class RegionMasterEntity
    {
        public RegionMasterEntity()
        {
   //       AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
    //      ZoneMasters = new HashSet<ZoneMasterEntity>();
        }


        public int RegionId { get; set; }

        public string RegionName { get; set; } = null!;

        public RegionMasterEntity(RegionMaster model)
        {
            this.RegionId = model.RegionId;
            this.RegionName = model.RegionName;

        }

        //    public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }

        //   public virtual ICollection<ZoneMasterEntity> ZoneMasters { get; set; }

    }
}
