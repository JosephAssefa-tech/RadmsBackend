using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class VictimDetailsTransactionEntity
    {

        public decimal AccidentId { get; set; }

        public string VictimId { get; set; } = null!;

        public string VictimName { get; set; } = null!;
        public int Age { get; set; }
        public int GenderType { get; set; }

        public int VictimMovementId { get; set; }

        public int VictimTypeId { get; set; }

        public int EmploymentStatusId { get; set; }
        public int? SeatBeltUsed { get; set; }
        public int? AirbadDeployed { get; set; }
        public int? HelmetUsed { get; set; }

        public int? HealthConditionId { get; set; }

        public int? PedestrianMovementId { get; set; }
    
        public int? SeatingTypeId { get; set; }


        public virtual AccidentDetailsTransactionEntity Accident { get; set; } = null!;

        public virtual EmploymentStatusLookupEntity EmploymentStatus { get; set; } = null!;

        public virtual HealthConditionLookupEntity? HealthCondition { get; set; }

        public virtual PedestrianMovementLookupEntity? PedestrianMovement { get; set; }

        public virtual SeatingTypeLookupEntity? SeatingType { get; set; }

        public virtual VictimMovementMasterEntity VictimMovement { get; set; } = null!;

        public virtual VictimTypeLookupEntity VictimType { get; set; } = null!;

    }
}
