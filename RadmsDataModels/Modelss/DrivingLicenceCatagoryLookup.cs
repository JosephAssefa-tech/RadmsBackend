using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("DrivingLicenceCatagoryLookup")]
    public partial class DrivingLicenceCatagoryLookup
    {
        public DrivingLicenceCatagoryLookup()
        {
            VehicleDetailsTransactions = new HashSet<VehicleDetailsTransaction>();
        }

        [Key]
        [Column("DrivingLicenceCatagoryID")]
        public int DrivingLicenceCatagoryId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string DrivingLicenceCatagoryName { get; set; } = null!;
        [StringLength(255)]
        public string? DrivingLicenceCatagoryNameAm { get; set; }
        [StringLength(255)]
        public string? DrivingLicenceCatagoryNameOr { get; set; }
        [StringLength(255)]
        public string? DrivingLicenceCatagoryNameTi { get; set; }
        [StringLength(255)]
        public string? DrivingLicenceCatagoryNameAf { get; set; }
        [StringLength(255)]
        public string? DrivingLicenceCatagoryNameSo { get; set; }

        [InverseProperty("Dlcatagory")]
        public virtual ICollection<VehicleDetailsTransaction> VehicleDetailsTransactions { get; set; }
    }
}
