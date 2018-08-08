using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    [Table("aspnet_Users")]
    public partial class AspnetUsers1
    {
        public AspnetUsers1()
        {
            AspnetPersonalizationPerUser = new HashSet<AspnetPersonalizationPerUser>();
            AspnetUsersInRoles = new HashSet<AspnetUsersInRoles>();
            Users = new HashSet<Users>();
        }

        public Guid ApplicationId { get; set; }
        [Key]
        public Guid UserId { get; set; }
        [Required]
        [StringLength(256)]
        public string UserName { get; set; }
        [Required]
        [StringLength(256)]
        public string LoweredUserName { get; set; }
        [StringLength(16)]
        public string MobileAlias { get; set; }
        public bool IsAnonymous { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastActivityDate { get; set; }

        [ForeignKey("ApplicationId")]
        [InverseProperty("AspnetUsers1")]
        public AspnetApplications Application { get; set; }
        [InverseProperty("User")]
        public AspnetMembership AspnetMembership { get; set; }
        [InverseProperty("User")]
        public AspnetProfile AspnetProfile { get; set; }
        [InverseProperty("User")]
        public ICollection<AspnetPersonalizationPerUser> AspnetPersonalizationPerUser { get; set; }
        [InverseProperty("User")]
        public ICollection<AspnetUsersInRoles> AspnetUsersInRoles { get; set; }
        [InverseProperty("User")]
        public ICollection<Users> Users { get; set; }
    }
}
