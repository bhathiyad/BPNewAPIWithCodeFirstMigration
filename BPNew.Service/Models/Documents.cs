using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    [Table("Documents", Schema = "PreBoard")]
    public partial class Documents
    {
        public Documents()
        {
            PbdocVersions = new HashSet<PbdocVersions>();
        }

        [Key]
        public int DocumentId { get; set; }
        public int MeetingId { get; set; }
        public Guid WorkflowId { get; set; }
        public byte WorkflowType { get; set; }
        [Required]
        [StringLength(500)]
        public string DocumentName { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(500)]
        public string Keywords { get; set; }
        [Column("PBDocType")]
        public byte PbdocType { get; set; }
        public int? ParentDocId { get; set; }
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
        public bool IsDeleted { get; set; }
        [StringLength(250)]
        public string DocumentFrom { get; set; }
        [StringLength(250)]
        public string DocumentTo { get; set; }
        [StringLength(250)]
        public string DocumentSubject { get; set; }
        [StringLength(50)]
        public string DocumentRefNo { get; set; }

        [ForeignKey("CreatedBy")]
        [InverseProperty("DocumentsCreatedByNavigation")]
        public Users CreatedByNavigation { get; set; }
        [ForeignKey("MeetingId")]
        [InverseProperty("Documents")]
        public Meetings Meeting { get; set; }
        [ForeignKey("ModifiedBy")]
        [InverseProperty("DocumentsModifiedByNavigation")]
        public Users ModifiedByNavigation { get; set; }
        [InverseProperty("Document")]
        public ICollection<PbdocVersions> PbdocVersions { get; set; }
    }
}
