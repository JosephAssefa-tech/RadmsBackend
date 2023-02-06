using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataAccessLogic.Models
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

        [InverseProperty("Dlcatagory")]
        public virtual ICollection<VehicleDetailsTransaction> VehicleDetailsTransactions { get; set; }
    }
}
