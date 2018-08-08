using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    [Table("aspnet_UsersInRoles")]
    public partial class AspnetUsersInRoles
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
        [Required]
        public byte[] TimeStamp { get; set; }

        [ForeignKey("RoleId")]
        [InverseProperty("AspnetUsersInRoles")]
        public AspnetRoles1 Role { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("AspnetUsersInRoles")]
        public AspnetUsers1 User { get; set; }
    }
}
