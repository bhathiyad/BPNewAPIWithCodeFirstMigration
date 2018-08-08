using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class Accesses
    {
        [Key]
        public int AccessId { get; set; }
        public int Type { get; set; }
        public int RefId { get; set; }
        public Guid RoleId { get; set; }
        public int CustomUserId { get; set; }
        [Required]
        public byte[] TimeStamp { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        public int? IpadDisplayOrder { get; set; }

        [ForeignKey("CustomUserId")]
        [InverseProperty("Accesses")]
        public Users CustomUser { get; set; }
        [ForeignKey("RoleId")]
        [InverseProperty("Accesses")]
        public AspnetRoles1 Role { get; set; }
    }
}
