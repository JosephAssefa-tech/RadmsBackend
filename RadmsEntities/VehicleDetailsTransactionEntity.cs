using RadmsDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class VehicleDetailsTransactionEntity
    {
   
       public  VehicleDetailsTransactionEntity()
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
        public int? AlcholTested { get; set; }
        public int? AlcohalConsumptionLevel { get; set; }
        public int ValidInsurance { get; set; }
        public int AccuseStatus { get; set; }

        //public virtual AccidentDetailsTransactionEntity Accident { get; set; } = null!;

        //public virtual DrivingLicenceCatagoryLookupEntity Dlcatagory { get; set; } = null!;

        //public virtual LicenceLevelLookupEntity? Dllevel { get; set; }

        //public virtual DriverExperienceLookupEntity? DriverExperience { get; set; }

        //public virtual EducationLevelLookupEntity? EducationLevel { get; set; }

        //public virtual VechicleMasterEntity Vehicle { get; set; } = null!;

        //public virtual VehicleServiceAgeLookupEntity? VehicleAge { get; set; }

        //public virtual VehicleDefectLookupEntity? VehicleDefect { get; set; }

        //public virtual VehicleMovementMasterEntity VehicleMovement { get; set; } = null!;

        //public virtual VehicleOwnershipLookupEntity VehicleOwnership { get; set; } = null!;

        //public virtual VehicleRelationLookupEntity? VehicleRelation { get; set; }

        public VehicleDetailsTransactionEntity(VehicleDetailsTransaction model)
        {
            this.NumberPlate = model.NumberPlate;
            this.DriverName = model.DriverName;
            this.DriverAge = model.DriverAge;
            this.Dlstatus = model.Dlstatus;
            this.Dlnumber = model.Dlnumber;
            this.IsOverSpeed = model.IsOverSpeed;
            this.RecordedSpeed = model.RecordedSpeed;
            this.IsAlcohalConsumed=model.IsAlcohalConsumed;
            this.AlcholTested = model.AlcholTested;
            this.AlcohalConsumptionLevel=model.AlcohalConsumptionLevel;
            this.ValidInsurance=model.ValidInsurance;
            this.AccuseStatus = model.AccuseStatus;


            this.VehicleInvolvedId = model.VehicleInvolvedId;
            this.AccidentId=model.AccidentId;
            this.VehicleId = model.VehicleId;
            this.VehicleAgeId = model.VehicleAgeId;
            this.VehicleDefectId = model.VehicleDefectId;
            this.DlcatagoryId = model.DlcatagoryId;
            this.EducationLevelId = model.EducationLevelId;
            this.DriverExperienceId = model.DriverExperienceId;
            this.VehicleOwnershipId = model.VehicleOwnershipId;
            this.GenderId = model.GenderId;
            this.DllevelId = model.DllevelId;
            this.VehicleRelationId = model.VehicleRelationId;
            this.VehicleMovementId = model.VehicleMovementId;




        //this.Accident = new AccidentDetailsTransactionEntity(model.Accident);
        //this.Vehicle = new VechicleMasterEntity(model.Vehicle);
        //this.VehicleAge = new VehicleServiceAgeLookupEntity(model.VehicleAge);
        //this.VehicleDefect = new VehicleDefectLookupEntity(model.VehicleDefect);
        //this.Dlcatagory=new DrivingLicenceCatagoryLookupEntity(model.Dlcatagory);
        ////GenderId
        //this.Dllevel = new LicenceLevelLookupEntity(model.Dllevel);
        //this.VehicleMovement = new VehicleMovementMasterEntity(model.VehicleMovement);
        //this.DriverExperience=new DriverExperienceLookupEntity(model.DriverExperience);
        //this.EducationLevel = new EducationLevelLookupEntity(model.EducationLevel);
        //this.VehicleOwnership=new VehicleOwnershipLookupEntity(model.VehicleOwnership);
        //this.VehicleRelation=new VehicleRelationLookupEntity(model.VehicleRelation);


    }
        public T MapToModel<T>() where T : class
        {
            VehicleDetailsTransaction model = new VehicleDetailsTransaction();
            model.NumberPlate = this.NumberPlate;
            model.DriverName = this.DriverName;
            model.DriverAge = this.DriverAge;
            model.Dlstatus = this.Dlstatus;
            model.Dlnumber = this.Dlnumber;
            model.IsOverSpeed = this.IsOverSpeed;
            model.RecordedSpeed = this.RecordedSpeed;
            model.IsAlcohalConsumed = this.IsAlcohalConsumed;
            model.AlcholTested = this.AlcholTested;
            model.AlcohalConsumptionLevel = this.AlcohalConsumptionLevel;
            model.ValidInsurance = this.ValidInsurance;
            model.AccuseStatus = this.AccuseStatus;


            model.VehicleInvolvedId = this.VehicleInvolvedId;
            model.AccidentId = this.AccidentId;
            model.VehicleId = this.VehicleId;
            model.VehicleAgeId = this.VehicleAgeId;
            model.VehicleDefectId = this.VehicleDefectId;
            model.DlcatagoryId = this.DlcatagoryId;
            model.EducationLevelId = this.EducationLevelId;
            model.DriverExperienceId = this.DriverExperienceId;
            model.VehicleOwnershipId = this.VehicleOwnershipId;
            model.GenderId = this.GenderId;
            model.DllevelId = this.DllevelId;
            model.VehicleRelationId = this.VehicleRelationId;
            model.VehicleMovementId = this.VehicleMovementId;

            //model.AccidentId = this.Accident.AccidentId;
            //model.VehicleId = this.Vehicle.VehicleId;
            //model.VehicleAgeId = this.VehicleAge.VehicleServiceAgeId;
            //model.VehicleDefectId = this.VehicleDefect.VehicleDefectId;
            //model.DlcatagoryId = this.Dlcatagory.DrivingLicenceCatagoryId;
            //model.VehicleRelationId = this.VehicleRelation.VehicleRelationId;
            //model.VehicleMovementId=this.VehicleMovement.VehicleMovementId;
            //model.DllevelId = this.Dllevel.LeveloflicenceId;
            //model.VehicleMovementId = this.VehicleMovement.VehicleMovementId;
            //model.VehicleOwnershipId = this.VehicleOwnership.VehicleOwnershipId;
            //model.DriverExperienceId = this.DriverExperience.DriverExperienceId;
            //model.EducationLevelId = this.EducationLevel.EducationLevelId;
            // model.GenderId=this.




            return model as T;

        }


        }
}
