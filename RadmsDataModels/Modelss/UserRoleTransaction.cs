using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("UserRoleTransaction")]
    public partial class UserRoleTransaction
    {
        [Key]
        [Column("DepartmentTypeID")]
        public int DepartmentTypeId { get; set; }
        [Column("UserTypeID")]
        public int? UserTypeId { get; set; }
        [Column("FormID")]
        public int? FormId { get; set; }

        [ForeignKey("FormId")]
        [InverseProperty("UserRoleTransactions")]
        public virtual FormMaster? Form { get; set; }
        [ForeignKey("UserTypeId")]
        [InverseProperty("UserRoleTransactions")]
        public virtual UserTypeLookup? UserType { get; set; }
    }
}
