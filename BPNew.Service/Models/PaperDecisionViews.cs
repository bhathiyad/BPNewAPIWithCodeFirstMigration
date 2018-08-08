using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class PaperDecisionViews
    {
        public int PaperId { get; set; }
        public int CustomUserId { get; set; }
        public byte DecisionStatus { get; set; }
        public byte NotificationStatus { get; set; }
        [Required]
        [StringLength(255)]
        public string NotificationDescription { get; set; }
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
        [Column(TypeName = "datetime")]
        public DateTime? ApprovalDate { get; set; }
        [StringLength(500)]
        public string ApprovalComment { get; set; }
        public byte IsAllowed { get; set; }
        public byte IsAllowDigitalSign { get; set; }
        [Column("DSApprovalStatus")]
        public byte DsapprovalStatus { get; set; }
        [Column("DSPrivateComment")]
        public string DsprivateComment { get; set; }
        [Column("DSPublicComment")]
        public string DspublicComment { get; set; }
        [Column("DSApprovalDate", TypeName = "datetime")]
        public DateTime? DsapprovalDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ViewedDate { get; set; }

        [ForeignKey("CustomUserId")]
        [InverseProperty("PaperDecisionViews")]
        public Users CustomUser { get; set; }
        [ForeignKey("PaperId")]
        [InverseProperty("PaperDecisionViews")]
        public Papers Paper { get; set; }
    }
}
