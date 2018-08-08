using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    [Table("UserDSDetails")]
    public partial class UserDsdetails
    {
        [Key]
        public int CustomUserId { get; set; }
        [Required]
        [StringLength(100)]
        public string IdentityNumber { get; set; }
        public byte IdType { get; set; }
        [StringLength(255)]
        public string IdentityStatusComment { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CertificateExpiryDate { get; set; }
        public byte? CertificateStatus { get; set; }
        [StringLength(255)]
        public string SecretWord { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Required]
        [StringLength(250)]
        public string Country { get; set; }

        [ForeignKey("CustomUserId")]
        [InverseProperty("UserDsdetails")]
        public Users CustomUser { get; set; }
    }
}
