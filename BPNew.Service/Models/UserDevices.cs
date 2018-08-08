using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class UserDevices
    {
        public int CustomUserId { get; set; }
        [StringLength(100)]
        public string DeviceId { get; set; }
        public bool Status { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [StringLength(500)]
        public string Info1 { get; set; }
        [StringLength(250)]
        public string Info2 { get; set; }
        public int? Info3 { get; set; }
        [Required]
        public byte[] TimeStamp { get; set; }
        [Column("DSStatus")]
        public byte? Dsstatus { get; set; }

        [ForeignKey("CustomUserId")]
        [InverseProperty("UserDevices")]
        public Users CustomUser { get; set; }
    }
}
