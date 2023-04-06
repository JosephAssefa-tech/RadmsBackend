using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class VechicleDetailTransactionPostModel
    {
        public VechicleDetailTransactionPostModel()
        {

        }
        public decimal AccidentId { get; set; }

        public decimal VehicleInvolvedId { get; set; }

        public int VehicleId { get; set; }

        public string? NumberPlate { get; set; }

        public int? VehicleAgeId { get; set; }
        public int? VehicleDefectId { get; set; }

        public string? DriverName { get; set; }

        public int DlcatagoryId { get; set; }
        public int DriverAge { get; set; }

        public int? EducationLevelId { get; set; }

        public int? DriverExperienceId { get; set; }//

        public int VehicleOwnershipId { get; set; }//

        public int GenderId { get; set; }

        public int Dlstatus { get; set; }

        public int? DllevelId { get; set; }//

        public string? Dlnumber { get; set; }

        public int? VehicleRelationId { get; set; }//

        public int VehicleMovementId { get; set; }
        public int? IsOverSpeed { get; set; }
        public int? RecordedSpeed { get; set; }
        public int? IsAlcohalConsumed { get; set; }
        public int? AlcohalConsumptionLevel { get; set; }
        public int ValidInsurance { get; set; }
        public int AccuseStatus { get; set; }

        public virtual AccidentDetailsTransactionPostModel Accident { get; set; } = null!;

        public virtual DrivingLicenceCatagoryLookupPostModel Dlcatagory { get; set; } = null!;

        public virtual LicenceLevelLookupPostModel? Dllevel { get; set; }

        public virtual DriverExperienceLookupPostModel? DriverExperience { get; set; }

        public virtual EducationLevelLookupPostModel? EducationLevel { get; set; }

        public virtual VechicleMasterPostModel Vehicle { get; set; } = null!;

        public virtual VehicleServiceAgeLookupPostModel? VehicleAge { get; set; }

        public virtual VehicleDefectLookupPostModel? VehicleDefect { get; set; }

        public virtual VehicleMovementMasterPostModel VehicleMovement { get; set; } = null!;

        public virtual VehicleOwnershipLookupPostModel VehicleOwnership { get; set; } = null!;

        public virtual VehicleRelationLookupPostModel? VehicleRelation { get; set; }

        public VechicleDetailTransactionPostModel(VehicleDetailsTransactionEntity entity)
        {
            this.VehicleInvolvedId = entity.VehicleInvolvedId;
            this.NumberPlate = entity.NumberPlate;
            this.DriverName = entity.DriverName;
            this.DriverAge = entity.DriverAge;
            this.Dlstatus = entity.Dlstatus;
            this.IsOverSpeed = entity.IsOverSpeed;
            this.RecordedSpeed = entity.RecordedSpeed;
            this.IsAlcohalConsumed = entity.IsAlcohalConsumed;
            this.AlcohalConsumptionLevel = entity.AlcohalConsumptionLevel;
            this.ValidInsurance = entity.ValidInsurance;
            this.AccuseStatus = entity.AccuseStatus;


            this.Accident = new AccidentDetailsTransactionPostModel(entity.Accident);
            this.Dlcatagory = new DrivingLicenceCatagoryLookupPostModel(entity.Dlcatagory);
            this.Dllevel = new LicenceLevelLookupPostModel(entity.Dllevel);
            this.DriverExperience = new DriverExperienceLookupPostModel(entity.DriverExperience);
            this.EducationLevel = new EducationLevelLookupPostModel(entity.EducationLevel);
            this.Vehicle = new VechicleMasterPostModel(entity.Vehicle);
            this.VehicleAge = new VehicleServiceAgeLookupPostModel(entity.VehicleAge);
            this.VehicleDefect = new VehicleDefectLookupPostModel(entity.VehicleDefect);
            this.VehicleMovement = new VehicleMovementMasterPostModel(entity.VehicleMovement);
            this.VehicleOwnership = new VehicleOwnershipLookupPostModel(entity.VehicleOwnership);
            this.VehicleRelation = new VehicleRelationLookupPostModel(entity.VehicleRelation);




        }
        public T MapToViewEntity<T>() where T : class
        {
            VehicleDetailsTransactionEntity entity = new VehicleDetailsTransactionEntity();
            entity.VehicleInvolvedId = this.VehicleInvolvedId;
            entity.VehicleId = this.VehicleId;
            entity.NumberPlate = this.NumberPlate;
            entity.DriverName = this.DriverName;
            entity.DriverAge = this.DriverAge;
            entity.Dlstatus = this.Dlstatus;
            entity.IsOverSpeed = this.IsOverSpeed;
            entity.RecordedSpeed = this.RecordedSpeed;
            entity.IsAlcohalConsumed = this.IsAlcohalConsumed;
            entity.AlcohalConsumptionLevel = this.AlcohalConsumptionLevel;
            entity.ValidInsurance = this.ValidInsurance;
            entity.AccuseStatus = this.AccuseStatus;

            entity.Accident = this.Accident.MapToViewEntity<AccidentDetailsTransactionEntity>();
            entity.Dlcatagory = this.Dlcatagory.MapToViewEntity<DrivingLicenceCatagoryLookupEntity>();// (entity.Dlcatagory);
            entity.Dllevel = this.Dllevel.MapToViewEntity <LicenceLevelLookupEntity >();
            entity.DriverExperience = this.DriverExperience.MapToViewEntity <DriverExperienceLookupEntity >();
            entity.EducationLevel = this.EducationLevel.MapToViewEntity <EducationLevelLookupEntity >();
            entity.Vehicle = this.Vehicle.MapToViewEntity <VechicleMasterEntity >();
            entity.VehicleAge = this.VehicleAge.MapToViewEntity <VehicleServiceAgeLookupEntity >();
            entity.VehicleDefect = this.VehicleDefect.MapToViewEntity <VehicleDefectLookupEntity >();
            entity.VehicleMovement = this.VehicleMovement.MapToViewEntity <VehicleMovementMasterEntity >();
            entity.VehicleOwnership = this.VehicleOwnership.MapToViewEntity <VehicleOwnershipLookupEntity >();
            entity.VehicleRelation = this.VehicleRelation.MapToViewEntity <VehicleRelationLookupEntity >();
            return entity as T;
        }
    }
}