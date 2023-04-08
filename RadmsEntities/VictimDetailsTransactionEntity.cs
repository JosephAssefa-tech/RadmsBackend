using RadmsDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class VictimDetailsTransactionEntity
    {
        public VictimDetailsTransactionEntity()
        {
            //VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
            //VictimDetailsTransactions = new HashSet<VictimDetailsTransactionEntity>();
        }
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


        //public virtual AccidentDetailsTransactionEntity Accident { get; set; } = null!;

        //public virtual EmploymentStatusLookupEntity EmploymentStatus { get; set; } = null!;

        //public virtual HealthConditionLookupEntity? HealthCondition { get; set; }

        //public virtual PedestrianMovementLookupEntity? PedestrianMovement { get; set; }

        //public virtual SeatingTypeLookupEntity? SeatingType { get; set; }

        //public virtual VictimMovementMasterEntity VictimMovement { get; set; } = null!;

        //public virtual VictimTypeLookupEntity VictimType { get; set; } = null!;


        public VictimDetailsTransactionEntity(VictimDetailsTransaction model)
        {
     
            this.VictimName = model.VictimName;
            this.Age=model.Age;
            this.GenderType = model.GenderType;
            this.SeatBeltUsed = model.SeatBeltUsed;
            this.AirbadDeployed = model.AirbadDeployed;
            this.HelmetUsed = model.HelmetUsed;

            //this.Accident = new AccidentDetailsTransactionEntity(model.Accident);
            //this.EmploymentStatus = new EmploymentStatusLookupEntity(model.EmploymentStatus);
            //this.HealthCondition = new HealthConditionLookupEntity(model.HealthCondition);
            //this.PedestrianMovement = new PedestrianMovementLookupEntity(model.PedestrianMovement);
            //this.SeatingType = new SeatingTypeLookupEntity(model.SeatingType);
            //this.VictimMovement = new VictimMovementMasterEntity(model.VictimMovement);
            //this.VictimType = new VictimTypeLookupEntity(model.VictimType);
            this.AccidentId =model.AccidentId;
            this.VictimId = model.VictimId;
            this.VictimMovementId = model.VictimMovementId;
            this.VictimTypeId =model.VictimTypeId;
            this.EmploymentStatusId=model.EmploymentStatusId;
            this.HealthConditionId =model.HealthConditionId;
            this.PedestrianMovementId=model.PedestrianMovementId;
            this.SeatingTypeId =model.SeatingTypeId;

        }
        public T MapToModel<T>() where T : class
        {
            VictimDetailsTransaction model = new VictimDetailsTransaction();
   
            model.VictimName = this.VictimName;
            model.Age = this.Age;
            model.GenderType = this.GenderType;
            model.SeatBeltUsed = this.SeatBeltUsed;
            model.AirbadDeployed = this.AirbadDeployed;
            model.HelmetUsed = this.HelmetUsed;

            //model.AccidentId = this.Accident.AccidentId;
            //model.VictimMovementId = this.VictimMovement.VictimMovementId;
            //model.VictimTypeId = this.VictimType.VictimTypeId;
            //model.EmploymentStatusId = this.EmploymentStatus.EmploymentStatusId;
            //model.VictimMovementId = this.VictimMovement.VictimMovementId;
            //model.HealthConditionId = this.HealthCondition.HealthConditionId;
            //model.PedestrianMovementId = this.PedestrianMovement.PedestrianMovementId;
            //model.SeatingTypeId = this.SeatingType.SeatingTypeId;
            model.AccidentId = this.AccidentId;
            model.VictimId = this.VictimId;
            model.VictimMovementId = this.VictimMovementId;
            model.VictimTypeId = this.VictimTypeId;
            model.EmploymentStatusId = this.EmploymentStatusId;
            model.HealthConditionId = this.HealthConditionId;
            model.PedestrianMovementId = this.PedestrianMovementId;
            model.SeatingTypeId = this.SeatingTypeId;
            return model as T;

        }

        }
}
