using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataAccessLogic.Models
{
    [Table("UserTypeLookup")]
    public partial class UserTypeLookup
    {
        public UserTypeLookup()
        {
            UserRoleTransactions = new HashSet<UserRoleTransaction>();
        }

        [Key]
        [Column("UserTypeID")]
        public int UserTypeId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string UserTypeName { get; set; } = null!;

        [InverseProperty("UserType")]
        public virtual ICollection<UserRoleTransaction> UserRoleTransactions { get; set; }
    }
}
