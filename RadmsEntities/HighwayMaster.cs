using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

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

        public int? HtypeId { get; set; }

        public string? HownerId { get; set; }
        public int? Hlength { get; set; }
        public int? StartChange { get; set; }
        public int? EndChanage { get; set; }

        public virtual HighwayOwnerMasterEntity? Howner { get; set; }

        public virtual HighwayTypeLookupEntity? Htype { get; set; }

        public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }
    }
}
