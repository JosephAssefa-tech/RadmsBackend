using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class VictimDetailsTransactionPostModel
    {
        public VictimDetailsTransactionPostModel()
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


        //public virtual AccidentDetailsTransactionPostModel Accident { get; set; } = null!;

        //public virtual EmploymentStatusLookupPostModel EmploymentStatus { get; set; } = null!;

        //public virtual HealthConditionLookupPostModel? HealthCondition { get; set; }

        //public virtual PedestrianMovementLookupPostModel? PedestrianMovement { get; set; }

        //public virtual SeatingTypeLookupPostModel? SeatingType { get; set; }

        //public virtual VictimMovementMasterPostModel VictimMovement { get; set; } = null!;

        //public virtual VictimTypeLookupPostModel VictimType { get; set; } = null!;

        public VictimDetailsTransactionPostModel(VictimDetailsTransactionEntity entity)
        {
            this.VictimName = entity.VictimName;
            this.Age = entity.Age;
            this.GenderType = entity.GenderType;
            this.SeatBeltUsed = entity.SeatBeltUsed;
            this.AirbadDeployed = entity.AirbadDeployed;
            this.HelmetUsed = entity.HelmetUsed;

            //this.Accident = new AccidentDetailsTransactionPostModel(entity.Accident);
            //this.EmploymentStatus = new EmploymentStatusLookupPostModel(entity.EmploymentStatus);
            //this.HealthCondition = new HealthConditionLookupPostModel(entity.HealthCondition);
            //this.PedestrianMovement = new PedestrianMovementLookupPostModel(entity.PedestrianMovement);
            //this.SeatingType = new SeatingTypeLookupPostModel(entity.SeatingType);
            //this.VictimMovement = new VictimMovementMasterPostModel(entity.VictimMovement);
            //this.VictimType = new VictimTypeLookupPostModel(entity.VictimType);
            this.AccidentId = entity.AccidentId;
            this.VictimId = entity.VictimId;
            this.VictimMovementId = entity.VictimMovementId;
            this.VictimTypeId = entity.VictimTypeId;
            this.EmploymentStatusId = entity.EmploymentStatusId;
            this.HealthConditionId = entity.HealthConditionId;
            this.PedestrianMovementId = entity.PedestrianMovementId;
            this.SeatingTypeId = entity.SeatingTypeId;


        }

        public T MapToViewEntity<T>() where T : class
        {
            VictimDetailsTransactionEntity entity = new VictimDetailsTransactionEntity();
            entity.VictimName = this.VictimName;
            entity.Age = this.Age;
            entity.GenderType = this.GenderType;
            entity.SeatBeltUsed = this.SeatBeltUsed;
            entity.AirbadDeployed = this.AirbadDeployed;
            entity.HelmetUsed = this.HelmetUsed;

            //entity.Accident = this.Accident.MapToViewEntity<AccidentDetailsTransactionEntity>();
            //entity.EmploymentStatus = this.EmploymentStatus.MapToViewEntity<EmploymentStatusLookupEntity>();// (entity.Dlcatagory);
            //entity.HealthCondition = this.HealthCondition.MapToViewEntity<HealthConditionLookupEntity>();// (entity.Dlcatagory);
            //entity.PedestrianMovement = this.PedestrianMovement.MapToViewEntity<PedestrianMovementLookupEntity>();// (entity.Dlcatagory);
            //entity.SeatingType = this.SeatingType.MapToViewEntity<SeatingTypeLookupEntity>();// (entity.Dlcatagory);
            //entity.VictimMovement = this.VictimMovement.MapToViewEntity<VictimMovementMasterEntity>();// (entity.Dlcatagory);
            //entity.VictimType = this.VictimType.MapToViewEntity<VictimTypeLookupEntity>();// (entity.Dlcatagory);
            //entity.EmploymentStatus = this.EmploymentStatus.MapToViewEntity<EmploymentStatusLookupEntity>();// (entity.Dlcatagory);
            entity.AccidentId = this.AccidentId;
            entity.VictimId = this.VictimId;
            entity.VictimMovementId = this.VictimMovementId;
            entity.VictimTypeId = this.VictimTypeId;
            entity.EmploymentStatusId = this.EmploymentStatusId;
            entity.HealthConditionId = this.HealthConditionId;
            entity.PedestrianMovementId = this.PedestrianMovementId;
            entity.SeatingTypeId = this.SeatingTypeId;
            return entity as T;

        }
    }
}
