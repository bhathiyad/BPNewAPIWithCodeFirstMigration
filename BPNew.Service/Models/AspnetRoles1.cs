using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    [Table("aspnet_Roles")]
    public partial class AspnetRoles1
    {
        public AspnetRoles1()
        {
            Accesses = new HashSet<Accesses>();
            AspnetUsersInRoles = new HashSet<AspnetUsersInRoles>();
        }

        public Guid ApplicationId { get; set; }
        [Key]
        public Guid RoleId { get; set; }
        [Required]
        [StringLength(256)]
        public string RoleName { get; set; }
        [Required]
        [StringLength(256)]
        public string LoweredRoleName { get; set; }
        public string IpadActions { get; set; }
        [Required]
        public string Description { get; set; }
        [StringLength(250)]
        public string ShortDescription { get; set; }

        [ForeignKey("ApplicationId")]
        [InverseProperty("AspnetRoles1")]
        public AspnetApplications Application { get; set; }
        [InverseProperty("Role")]
        public ICollection<Accesses> Accesses { get; set; }
        [InverseProperty("Role")]
        public ICollection<AspnetUsersInRoles> AspnetUsersInRoles { get; set; }
    }
}
