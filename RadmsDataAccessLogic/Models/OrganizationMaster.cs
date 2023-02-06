using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataAccessLogic.Models
{
    [Table("OrganizationMaster")]
    public partial class OrganizationMaster
    {
        public OrganizationMaster()
        {
            UserMasters = new HashSet<UserMaster>();
        }

        [Key]
        [Column("OrganizationID")]
        public int OrganizationId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string OrganizationName { get; set; } = null!;

        [InverseProperty("Organization")]
        public virtual ICollection<UserMaster> UserMasters { get; set; }
    }
}
