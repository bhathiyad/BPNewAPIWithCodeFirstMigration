using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class UserDetails
    {
        [Key]
        public int CustomUserId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PastDataAllowedFrom { get; set; }
        public int? PastDataAllowedFor { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [StringLength(3000)]
        public string RefId { get; set; }
        [Column("PIN")]
        [StringLength(512)]
        public string Pin { get; set; }
        [Column("PINSalt")]
        [StringLength(512)]
        public string Pinsalt { get; set; }

        [ForeignKey("CreatedBy")]
        [InverseProperty("UserDetailsCreatedByNavigation")]
        public Users CreatedByNavigation { get; set; }
        [ForeignKey("ModifiedBy")]
        [InverseProperty("UserDetailsModifiedByNavigation")]
        public Users ModifiedByNavigation { get; set; }
    }
}
