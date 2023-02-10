using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class VehicleDetailsTransactionEntity
    {

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

        public int? DriverExperienceId { get; set; }

        public int VehicleOwnershipId { get; set; }

        public int GenderId { get; set; }

        public int Dlstatus { get; set; }

        public int? DllevelId { get; set; }

        public string? Dlnumber { get; set; }

        public int? VehicleRelationId { get; set; }

        public int VehicleMovementId { get; set; }
        public int? IsOverSpeed { get; set; }
        public int? RecordedSpeed { get; set; }
        public int? IsAlcohalConsumed { get; set; }
        public int? AlcohalConsumptionLevel { get; set; }
        public int ValidInsurance { get; set; }
        public int AccuseStatus { get; set; }

        public virtual AccidentDetailsTransactionEntity Accident { get; set; } = null!;

        public virtual DrivingLicenceCatagoryLookupEntity Dlcatagory { get; set; } = null!;

        public virtual LicenceLevelLookupEntity? Dllevel { get; set; }

        public virtual DriverExperienceLookupEntity? DriverExperience { get; set; }

        public virtual EducationLevelLookupEntity? EducationLevel { get; set; }

        public virtual VechicleMasterEntity Vehicle { get; set; } = null!;

        public virtual VehicleServiceAgeLookupEntity? VehicleAge { get; set; }

        public virtual VehicleDefectLookupEntity? VehicleDefect { get; set; }

        public virtual VehicleMovementMasterEntity VehicleMovement { get; set; } = null!;

        public virtual VehicleOwnershipLookupEntity VehicleOwnership { get; set; } = null!;

        public virtual VehicleRelationLookupEntity? VehicleRelation { get; set; }

    }
}
